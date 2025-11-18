namespace DesktopApp;
using System.ComponentModel;

public abstract class CheckoutBase
{
    protected decimal _Amount = 0;
    protected BindingList<Item> _Items = new BindingList<Item>();
    protected TableLayoutPanel _Layout = new TableLayoutPanel() { Dock = DockStyle.Fill };
    public event EventHandler? UpdateUi;
    protected void Update() => UpdateUi?.Invoke(this, EventArgs.Empty);
    public BindingList<Item> Items => _Items;
    public TableLayoutPanel Layout => _Layout;
    public void AddItem(int code, int quantity = 1, bool set = false)
    {
        if (quantity < 0) return;
        if (quantity == 0) RemoveItem(code);

        var item = _Items.FirstOrDefault(i => i.Code == code);
        if (item != null)
        {
            if (set)
                item.Quantity = quantity;
            else
                item.Quantity += quantity;
            return;
        }

        var masterItem = Data.Items.FirstOrDefault(i => i.Code == code);
        if (masterItem == null) return;

        if (set)
            masterItem.Quantity = quantity;
        else
            masterItem.Quantity = DefaultQuantity;

        _Items.Add(new Item(masterItem.Name, masterItem.Price, masterItem.Code, masterItem.Category, masterItem.Quantity));
    }
    public void RemoveItem(int code)
    {
        var item = _Items.FirstOrDefault(i => i.Code == code);
        if (item != null) 
            _Items.Remove(item);
    }
    public virtual void ClearProperties(bool items = false, bool ui = false)
    {
        if (items) _Items.Clear();
        if (ui) UpdateUi = null;
    }
    protected virtual decimal Sum => ItemsSum;
    protected decimal ItemsSum  => _Items.Sum(i => i.Price * i.Quantity);
    public bool ValidQuantity() => _Items.Count != 0;
    public decimal Price => Math.Round(Sum, 2);
    public virtual int DefaultQuantity => 0;
    public virtual bool ValidTransaction()
    {
        bool valid = (Price <= _Amount);
        if (valid) Data.addTransaction(new Transaction(DateTime.Now, Price, Name));
        return valid;
    }
    public virtual string Name => "Base";
    public string OnComplete => ValidTransaction() ? CompleteText : "Invalid Transaction";
    protected virtual string CompleteText => "Complete";
}
public class CardRetail : CheckoutBase
{
    private decimal totalPurchased = 0;
    private bool paid = false;
    protected bool _LoyaltyCard = false;
    protected bool _Delivery = false;
    private Button pay;
    private CheckBox loyaltyCard;
    private CheckBox delivery;
    protected virtual string loyaltyCardText => "Do you have loyalty card? (-5%)";
    protected virtual string deliveryText => "Do you want your items to be delivered by courier? (+250)";
    public CardRetail()
    {
        pay = new  Button() { Text = "Pay" };
        loyaltyCard = new CheckBox() { Text = loyaltyCardText, Dock = DockStyle.Fill };
        delivery = new CheckBox() { Text = deliveryText, Dock = DockStyle.Fill };
        
        loyaltyCard.CheckedChanged += (s, e) => { _LoyaltyCard = loyaltyCard.Checked; Update(); };
        delivery.CheckedChanged += (s, e) => { _Delivery = delivery.Checked; Update(); };
        pay.Click += (s, e) =>
        {
            if (paid == true) { pay.Text = "Already Paid"; return; }
            paid = true; pay.Text = "Success"; totalPurchased += Price; Update();
        };

        for (int i = 0; i < 3; i++)
            _Layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        _Layout.Controls.Add(loyaltyCard, 0, 0);
        _Layout.Controls.Add(delivery, 0, 1);
        _Layout.Controls.Add(pay, 0, 2);
    }
    public override void ClearProperties(bool items = false, bool ui = false)
    {
        base.ClearProperties(items,ui);
        pay.Text = "Pay";
        paid = false;
        loyaltyCard.Checked = false;
        delivery.Checked = false;
    }
    protected override decimal Sum => ItemsSum * (_LoyaltyCard ? 0.95m : 1) + (_Delivery ? 250m : 0);
    public override bool ValidTransaction()
    {
        if (paid) Data.addTransaction(new Transaction(DateTime.Now, Price, Name));
        return paid;
    }
    public override int DefaultQuantity => 1;
    public override string Name => "Card Retail";
    protected override string CompleteText => "Transaction complete - " + totalPurchased + " UAH\nHave a nice day!";
}
public class CashRetail : CheckoutBase
{
    private decimal _Amount = 0;
    protected bool _LoyaltyCard = false;
    protected bool _Delivery = false;
    private NumericUpDown paidAmount;
    private CheckBox loyaltyCard;
    private CheckBox delivery;
    protected virtual string loyaltyCardText => "Do you have loyalty card? (-5%)";
    protected virtual string deliveryText => "Do you want your items to be delivered by courier? (+250)";
    public CashRetail()
    {
        paidAmount = new NumericUpDown() { Minimum = 0m, Maximum = 999999m, DecimalPlaces = 2, 
            Increment = 10m, Value = 1m, Dock = DockStyle.Fill };
        loyaltyCard = new CheckBox() { Text = loyaltyCardText, Dock = DockStyle.Fill };
        delivery = new CheckBox() { Text = deliveryText, Dock = DockStyle.Fill };
        
        loyaltyCard.CheckedChanged += (s, e) => { _LoyaltyCard = loyaltyCard.Checked; Update(); };
        delivery.CheckedChanged += (s, e) => { _Delivery = delivery.Checked; Update(); };
        paidAmount.ValueChanged += (s, e) => { _Amount = paidAmount.Value; Update(); };

        for (int i = 0; i < 3; i++)
            _Layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        _Layout.Controls.Add(loyaltyCard, 0, 0);
        _Layout.Controls.Add(delivery, 0, 1);
        _Layout.Controls.Add(paidAmount, 0, 2);
    }
    public override void ClearProperties(bool items = false, bool ui = false)
    {
        base.ClearProperties(items, ui);
        _Amount = 0;
        loyaltyCard.Checked = false;
        delivery.Checked = false;
    }
    protected override decimal Sum => ItemsSum * (_LoyaltyCard ? 0.95m : 1) + (_Delivery ? 250m : 0);
    public override bool ValidTransaction() => (Price <= _Amount);
    public override int DefaultQuantity => 1;
    public override string Name => "Cash Retail";
    public decimal Change => _Amount - Price;
    protected override string CompleteText => "Your change: " + Change + ".\nHave a nice day!";
}
public class DeliveryRetail : CheckoutBase
{
    private decimal _Amount = 0;
    private NumericUpDown presentAmount;
    private Label delivery;
    protected virtual string deliveryText => "Your items will be delivered by courier (+250).\n" +
                                             "Enter, how much cash will you give to courier: ";
    public DeliveryRetail()
    {
        presentAmount = new NumericUpDown() { Minimum = 0m, Maximum = 999999m, DecimalPlaces = 2, 
            Increment = 10m, Value = 1m, Dock = DockStyle.Fill };
        delivery = new Label() { Text = deliveryText, Dock = DockStyle.Fill, MinimumSize = new Size(300, 35),};
        
        presentAmount.ValueChanged += (s, e) => { _Amount = presentAmount.Value; Update(); };

        for (int i = 0; i < 2; i++)
            _Layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        _Layout.Controls.Add(delivery, 0, 0);
        _Layout.Controls.Add(presentAmount, 0, 1);
    }
    public override void ClearProperties(bool items = false, bool ui = false)
    {
        base.ClearProperties(items, ui);
        _Amount = 0;
    }
    protected override decimal Sum => ItemsSum + 250m;
    public override bool ValidTransaction() => (Price <= _Amount);
    public override int DefaultQuantity => 1;
    public override string Name => "Delivery Retail";
    public decimal Change => _Amount - Price;
    protected override string CompleteText => "Your change on delivery will be: " + Change + ".\nHave a nice day!";
}
public class CashWholesale : CashRetail
{
    protected override string loyaltyCardText => "Do you have loyalty card? (-8%)";
    protected override string deliveryText => "Do you want your items to be delivered by courier? (+50)";
    protected override decimal Sum => ItemsSum * (_LoyaltyCard ? 0.92m : 1) + (_Delivery ? 50m : 0);
    public override int DefaultQuantity => 30;
}
public class CardWholesale : CardRetail
{
    protected override string loyaltyCardText => "Do you have loyalty card? (-8%)";
    protected override string deliveryText => "Do you want your items to be delivered by courier? (+50)";
    protected override decimal Sum => ItemsSum * (_LoyaltyCard ? 0.92m : 1) + (_Delivery ? 50m : 0);
    public override int DefaultQuantity => 30;
}
public class DeliveryWholesale : DeliveryRetail
{
    protected override string deliveryText => "Your items will be delivered by courier (delivery is free).\n" +
                                             "Enter, how much cash will you give to courier: ";
    protected override decimal Sum => ItemsSum;
    public override int DefaultQuantity => 50;
}
