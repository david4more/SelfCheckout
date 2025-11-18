namespace DesktopApp;

public partial class Form1 : Form
{
    CheckoutBase manager;

    public Form1()
    {
        InitializeComponent();

        itemsTable.DataSource = Data.Items;
        itemsTable.Columns["Quantity"].Visible = false;

        categoryCombobox.Items.Add("All");
        categoryCombobox.Items.AddRange(Data.Categories.ToArray());
        categoryCombobox.SelectedIndex = 0;

        cardCheckbox.Click += (s, e) => deliveryCheckbox.Checked = false;
        deliveryCheckbox.Click += (s, e) => cardCheckbox.Checked = false;

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

        adressLabel.Text = "Adress:\n" + Data.Adress;
    }
    private void proceedButton_Click(object sender, EventArgs e)
    {
        if (!cardCheckbox.Checked)
        {
            if (!Data.Cash) 
            { MessageBox.Show("Machine cannot accept cash", "Error"); return; }
            
            if (!deliveryCheckbox.Checked)
                manager = wholesaleCheckbox.Checked ? new CashWholesale() : new CashRetail();
            else
            {
                if (!Data.Online || !Data.Delivery || !Data.CashOnDelivery) {
                    MessageBox.Show("Online delivery order is not supported", "Error");
                }
                manager = wholesaleCheckbox.Checked ? new DeliveryWholesale() : new DeliveryRetail();
            }
        }
        else
            manager = wholesaleCheckbox.Checked ? new CardWholesale() : new CardRetail();

        manager.UpdateUi += (s, e) => Update();

        transactionLayout.Controls.Add(manager.Layout, 0, 0);
        itemsGroup.Text = manager.Name;
        pickedItemsTable.DataSource = manager.Items;
        transactionTable.DataSource = manager.Items;
        pages.SelectedIndex = 1;
    }
    private void categoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cat = categoryCombobox.SelectedItem.ToString();
        var filtered = (cat == "All") ? Data.Items : Data.Items.Where(c => c.Category == cat).ToList();
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
        if (manager.ValidQuantity()) pages.SelectedIndex = 2;
        else MessageBox.Show("Invalid quantity", "Error");
    }
    private void transactionProceedButton_Click(object sender, EventArgs e) 
    {
        if (!manager.ValidTransaction()) {
            MessageBox.Show("Invalid transaction", "Error");
            return;
        }

        backButton.Text = manager.OnComplete;
        pages.SelectedIndex = 3;
    }
    private void transactionBackButton_Click(object sender, EventArgs e)
    {
        manager.ClearProperties(true);
        Update();
        pages.SelectedIndex = 1;
    }
    private void backButton_Click(object sender, EventArgs e)
    {
        transactionLayout.Controls.Remove(manager.Layout);
        manager.ClearProperties(true, true);
        wholesaleCheckbox.Checked = false;
        cardCheckbox.Checked = false;
        deliveryCheckbox.Checked = false;
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
    private void adminButton_Click(object sender, EventArgs e) => pages.SelectedIndex = 4;
}
