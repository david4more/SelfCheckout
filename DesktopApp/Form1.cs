namespace DesktopApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        table.DataSource = Checkout.Items;

        //categoryCombobox.Items = Checkout.Categories;
    }

    private void proceedButton_Click(object sender, EventArgs e)
    {
        if (!cardCheckbox.Checked && !deliveryCheckbox.Checked && !wholesaleCheckbox.Checked)
        {
            pages.SelectedIndex = 2;
            CashRetail checkout = new CashRetail();
            
        }
    }

    private void categoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}
