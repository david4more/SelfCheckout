namespace DesktopApp;

public partial class Form1 : Form
{
    private CheckoutBase manager;

    public Form1()
    {
        InitializeComponent();
    }
    
    protected override void OnLoad(EventArgs e)
    {
        if (DesignMode) return;
        
        itemsTable.DataSource = Data.Items;
        itemsTable.Columns["Quantity"].Visible = false;

        categoryCombobox.Items.Add("All");
        categoryCombobox.Items.AddRange(Data.Categories.ToArray());
        categoryCombobox.SelectedIndex = 0;

        cardCheckbox.Click += (s, e) => { deliveryCheckbox.Checked = false; };
        deliveryCheckbox.Click += (s, e) => { cardCheckbox.Checked = false; };
        
        pickedItemsTable.DataSource = new System.ComponentModel.BindingList<Item>();
        pickedItemsTable.Columns["Category"].Visible = false;
        pickedItemsTable.Columns["Code"].Visible = false;
        pickedItemsTable.Columns["Name"].ReadOnly = true;
        pickedItemsTable.Columns["Price"].ReadOnly = true;
    }


    private void proceedButton_Click(object sender, EventArgs e)
    {
        if (!wholesaleCheckbox.Checked)
        {
            if (cardCheckbox.Checked)
            {
                manager =  new CardRetail();
            }
            else if (deliveryCheckbox.Checked)
            {
                manager = new DeliveryRetail();
            }
            else
            {
                manager = new CashRetail();
            }
        }
        else
        {
            if (cardCheckbox.Checked)
            {
                manager = new CardWholesale();
            }
            else if (deliveryCheckbox.Checked)
            {
                manager = new DeliveryWholesale();
            }
            else
            {
                manager = new CashWholesale();
            }
        }

        itemsGroup.Text = manager.Name;
        pickedItemsTable.DataSource = manager.Items;
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

        Update();
        pickedItemsTable.Refresh();
    }

    private void pickedItemsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (e.ColumnIndex == 4) return;

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

    private void Update()
    {
        itemsProceed.Text = manager.Sum() + "UAH - Proceed";
        pickedItemsTable.ClearSelection();
    }
}
