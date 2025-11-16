namespace DesktopApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    protected override void OnLoad(EventArgs e)
    {
        itemsTable.DataSource = CheckoutData.Items;
        itemsTable.Columns["Quantity"].Visible = false;

        categoryCombobox.Items.Add("All");
        categoryCombobox.Items.AddRange(CheckoutData.Categories);
        categoryCombobox.SelectedIndex = 0;

        cardCheckbox.Click += (s, e) => { deliveryCheckbox.Checked = false; };
        deliveryCheckbox.Click += (s, e) => { cardCheckbox.Checked = false; };
        
        pickedItemsTable.DataSource = new System.ComponentModel.BindingList<Item>();
        pickedItemsTable.Columns["Category"].Visible = false;
        pickedItemsTable.Columns["Code"].Visible = false;
    }


    private void proceedButton_Click(object sender, EventArgs e)
    {
        object checkout;
        if (!wholesaleCheckbox.Checked)
        {
            if (cardCheckbox.Checked)
            {
                checkout =  new CardRetail();
            }
            else if (deliveryCheckbox.Checked)
            {
                checkout = new DeliveryRetail();
            }
            else
            {
                checkout = new CashRetail();
                
            }
        }
        else
        {
            if (cardCheckbox.Checked)
            {
                checkout = new CardWholesale();
            }
            else if (deliveryCheckbox.Checked)
            {
                checkout = new DeliveryWholesale();
            }
            else
            {
                checkout = new CashWholesale();
            }
        }
        pages.SelectedIndex = 1;
    }

    private void categoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
        string cat = categoryCombobox.SelectedItem.ToString();
        var filtered = (cat == "All") ? CheckoutData.Items : CheckoutData.Items.Where(c => c.Category == cat).ToList();
        itemsTable.DataSource = filtered;
    }

    private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        Item clickedItem = (Item)itemsTable.Rows[e.RowIndex].DataBoundItem;
        System.ComponentModel.BindingList<Item> data = (System.ComponentModel.BindingList<Item>)pickedItemsTable.DataSource;
        
        var existingItem = data.FirstOrDefault(i => i.Code == clickedItem.Code);
        if (existingItem != null)
        {
            ++existingItem.Quantity;
            pickedItemsTable.Refresh();
        }
        else
            data.Add(clickedItem);

        itemsProceed.Text = data.Sum(i => i.Price) + "UAH - Proceed";

        pickedItemsTable.ClearSelection();
    }

    private void pickedItemsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        Item clickedItem = (Item)pickedItemsTable.Rows[e.RowIndex].DataBoundItem;
        clickedItem.Quantity = 1;

        System.ComponentModel.BindingList<Item> data = (System.ComponentModel.BindingList<Item>)pickedItemsTable.DataSource;
        data.Remove(clickedItem);

        itemsProceed.Text = data.Sum(i => i.Price) + "UAH - Proceed";
        
        pickedItemsTable.ClearSelection();
    }

}
