namespace DesktopApp;

public partial class ControlPanel : Form
{
    public ControlPanel()
    {
        InitializeComponent();
        
        nameLabel.Text = Supermarket.name;
        adressLabel.Text = Supermarket.Adress;
        numberLabel.Text = Supermarket.JuridicalNumber;
        
        cardCheckout.Click += (s, e) => deliveryCheckout.Checked = false;
        deliveryCheckout.Click += (s, e) => cardCheckout.Checked = false;;
    }
    private void addMachine_Click(object sender, EventArgs e)
    {
        if (!cardCheckout.Checked)
        {
            if (!Supermarket.Cash) 
            { MessageBox.Show("Machine cannot accept cash", "Error"); return; }
            
            if (!deliveryCheckout.Checked)
                Supermarket.AddCheckout(wholesaleCheckout.Checked ? new CashWholesale() : new CashRetail());
            else
            {
                if (!Supermarket.Online || !Supermarket.Delivery || !Supermarket.CashOnDelivery) 
                { MessageBox.Show("Online delivery order is not supported", "Error"); return; }
                
                Supermarket.AddCheckout(wholesaleCheckout.Checked ? new DeliveryWholesale() : new DeliveryRetail());
            }
        }
        else
            Supermarket.AddCheckout(wholesaleCheckout.Checked ? new CardWholesale() : new CardRetail());

        machineCombobox.Items.Add(Supermarket.Machines.Last().Key);
    }
    private void deleteButton_Click(object sender, EventArgs e) => 
        Supermarket.DeleteCheckout(machineCombobox.Text);
    private void cashOnDeliveryCheckbox_CheckedChanged(object sender, EventArgs e) =>
        Supermarket.CashOnDelivery = cashOnDeliveryCheckbox.Checked;
    private void cashCheckbox_CheckedChanged(object sender, EventArgs e) =>
        Supermarket.Cash = cashCheckbox.Checked;
    private void deliveryCheckbox_CheckedChanged(object sender, EventArgs e) =>
        Supermarket.Delivery = deliveryCheckbox.Checked;
    private void onlineCheckbox_CheckedChanged(object sender, EventArgs e) =>
        Supermarket.Online = onlineCheckbox.Checked;
    private void itemAdd_Click(object sender, EventArgs e)
    {
        if (Supermarket.Items.Any(i => i.Code == itemCode.Value))
        {
            Supermarket.StockUp((int)itemCode.Value, (int)itemQuantity.Value);
            MessageBox.Show("Quantity of the item increased", "Success");
            return;
        }
        
        if (string.IsNullOrWhiteSpace(itemName.Text) || string.IsNullOrWhiteSpace(itemCategory.Text) || itemPrice.Value == 0) 
            MessageBox.Show("Invalid input", "Error");
        
        Supermarket.AddItem(new Item(itemName.Text, itemPrice.Value, (int)itemCode.Value, itemCategory.Text, (int)itemQuantity.Value));
    }
    private void launchButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(machineCombobox.Text))
            MessageBox.Show("Checkout machine not selected", "Error");
        else
            new Machine(Supermarket.Machines[machineCombobox.Text]).Show();
    }
}