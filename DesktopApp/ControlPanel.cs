namespace DesktopApp;

public partial class ControlPanel : Form
{
    public ControlPanel()
    {
        InitializeComponent();

        cardCheckout.Click += (s, e) => deliveryCheckout.Checked = false;
        deliveryCheckout.Click += (s, e) => cardCheckout.Checked = false;

        transactionsTable.DataSource = Supermarket.getTransactions();
        itemsTable.DataSource = Supermarket.Items;
        itemsTable.Columns["Name"].Visible = false;
        itemsTable.Columns["Category"].Visible = false;
        itemsTable.Columns["Price"].Visible = false;
        
        UpdateData();
    }
    private void addMachine_Click(object sender, EventArgs e)
    {
        if (!cardCheckout.Checked)
        {
            if (!Supermarket.Cash) 
            { MessageBox.Show("Machine cannot accept cash", "Error"); return; }
            
            if (!deliveryCheckout.Checked)
                Supermarket.AddMachine(wholesaleCheckout.Checked ? new CashWholesale() : new CashRetail());
            else
            {
                if (!Supermarket.Online || !Supermarket.Delivery || !Supermarket.CashOnDelivery) 
                { MessageBox.Show("Online delivery order is not supported", "Error"); return; }
                
                Supermarket.AddMachine(wholesaleCheckout.Checked ? new DeliveryWholesale() : new DeliveryRetail());
            }
        }
        else
            Supermarket.AddMachine(wholesaleCheckout.Checked ? new CardWholesale() : new CardRetail());
        
        machineCombobox.DataSource = Supermarket.Machines.Keys.ToList();
    }
    private void cashOnDeliveryCheckbox_CheckedChanged(object sender, EventArgs e) =>
        Supermarket.CashOnDelivery = cashOnDeliveryCheckbox.Checked;
    private void cashCheckbox_CheckedChanged(object sender, EventArgs e) =>
        Supermarket.Cash = cashCheckbox.Checked;
    private void deliveryCheckbox_CheckedChanged(object sender, EventArgs e) =>
        Supermarket.Delivery = deliveryCheckbox.Checked;
    private void onlineCheckbox_CheckedChanged(object sender, EventArgs e) =>
        Supermarket.Online = onlineCheckbox.Checked;
    private void itemAdd_Click(object sender, EventArgs e) =>
        Supermarket.AddItem(new Item(itemName.Text, itemPrice.Value, itemCategory.Text, (int)itemQuantity.Value, (int)itemCode.Value));
    private void deleteButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(machineCombobox.Text))
            MessageBox.Show("No checkout machines available", "Error");
        else
            Supermarket.DeleteMachine(machineCombobox.Text);
        
        machineCombobox.DataSource = Supermarket.Machines.Keys.ToList();
        if (Supermarket.Machines.Keys.ToList().Count == 0) machineCombobox.Text = "";
    }
    private void launchButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(machineCombobox.Text))
            MessageBox.Show("No checkout machines available", "Error");
        else
            new Machine(Supermarket.Machines[machineCombobox.Text]).Show();
    }
    private void saveToFileButton_Click(object sender, EventArgs e)
    {
        Supermarket.Name = nameLabel.Text;
        Supermarket.Address = adressLabel.Text;
        Supermarket.JuridicalNumber = numberLabel.Text;
        Supermarket.SaveToFile();
    }
    private void loadFromFileButton_Click(object sender, EventArgs e)
    {
        Supermarket.LoadFromFile();
        UpdateData();
    }
    private void UpdateData()
    {
        nameLabel.Text = Supermarket.Name;
        adressLabel.Text = Supermarket.Address;
        numberLabel.Text = Supermarket.JuridicalNumber;
        
        machineCombobox.DataSource = Supermarket.Machines.Keys.ToList();
        
        cashCheckbox.Checked = Supermarket.Cash;
        deliveryCheckbox.Checked = Supermarket.Delivery;
        cashOnDeliveryCheckbox.Checked = Supermarket.CashOnDelivery;
        onlineCheckbox.Checked = Supermarket.Online;
    }
    private void saveTransactionsButton_Click(object sender, EventArgs e) => Supermarket.SaveTransactions();
}