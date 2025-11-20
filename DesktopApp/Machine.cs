namespace DesktopApp;

public partial class Machine : Form
{
    CheckoutBase manager;

    public Machine(CheckoutBase manager)
    {
        this.manager = manager;
        InitializeComponent();

        itemsTable.DataSource = Supermarket.Items;
        itemsTable.Columns["Quantity"].Visible = false;

        categoryCombobox.Items.Add("All");
        categoryCombobox.Items.AddRange(Supermarket.Categories.ToArray());
        categoryCombobox.SelectedIndex = 0;
        
        pickedItemsTable.DataSource = new System.ComponentModel.BindingList<Item>(); 
        pickedItemsTable.Columns["Category"].Visible = false;
        pickedItemsTable.Columns["Code"].Visible = false;
        pickedItemsTable.Columns["Name"].ReadOnly = true;
        pickedItemsTable.Columns["Price"].ReadOnly = true;
        
        transactionTable.DataSource = new System.ComponentModel.BindingList<Item>();
        transactionTable.Columns["Category"].Visible = false;
        transactionTable.Columns["Code"].Visible = false;
        transactionTable.Columns["Name"].ReadOnly = true;
        transactionTable.Columns["Price"].ReadOnly = true;
        
        
        manager.UpdateUi += (s, e) => Update();

        transactionLayout.Controls.Add(manager.Layout, 0, 0);
        itemsGroup.Text = manager.Name;
        pickedItemsTable.DataSource = manager.Items;
        transactionTable.DataSource = manager.Items;
    }
    private void categoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cat = categoryCombobox.SelectedItem.ToString();
        var filtered = (cat == "All") ? Supermarket.Items : Supermarket.Items.Where(c => c.Category == cat).ToList();
        itemsTable.DataSource = filtered;
    }
    private void itemsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        Item clickedItem = (Item)itemsTable.Rows[e.RowIndex].DataBoundItem;
        manager.AddItem(clickedItem.Code);

        pickedItemsTable.Refresh();
        Update();
    }
    private void pickedItemsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex == 4) return;

        Item clickedItem = (Item)pickedItemsTable.Rows[e.RowIndex].DataBoundItem;
        manager.RemoveItem(clickedItem.Code);

        Update();
    }
    private void pickedItemsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex != 4) throw new System.NotImplementedException();
        
        Item clickedItem = (Item)pickedItemsTable.Rows[e.RowIndex].DataBoundItem;
        manager.AddItem(clickedItem.Code, (clickedItem.Quantity < manager.DefaultQuantity) 
                ? manager.DefaultQuantity : clickedItem.Quantity, true);

        Update();
    }
    private void itemsProceed_Click(object sender, EventArgs e)
    {
        if (manager.ValidQuantity) pages.SelectedIndex = 1;
        else MessageBox.Show("Invalid quantity", "Error");
    }
    private void transactionProceedButton_Click(object sender, EventArgs e) 
    {
        if (!manager.ValidTransaction) {
            MessageBox.Show("Invalid transaction", "Error");
            return;
        }

        backButton.Text = manager.OnComplete;
        pages.SelectedIndex = 2;
    }
    private void transactionBackButton_Click(object sender, EventArgs e)
    {
        Update();
        pages.SelectedIndex = 0;
    }
    private void backButton_Click(object sender, EventArgs e)
    {
        transactionLayout.Controls.Remove(manager.Layout);
        manager.CompleteTransaction();
        pages.SelectedIndex = 0;
        Update();
    }
    private void Update()
    {
        string text = manager.Price + " UAH - Proceed";
        itemsProceedButton.Text = text;
        transactionProceedButton.Text = text;
        pickedItemsTable.ClearSelection();
        transactionTable.ClearSelection();
    }
    private void transactionTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => pickedItemsTable_CellDoubleClick(sender, e);
    private void transactionTable_CellValueChanged(object sender, DataGridViewCellEventArgs e) => pickedItemsTable_CellValueChanged(sender, e);
}
