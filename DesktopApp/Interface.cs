namespace DesktopApp;
using System.ComponentModel;

public abstract class CheckoutBase
{
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
        
        _Items.Add(masterItem);
    }
    public void RemoveItem(int code)
    {
        var item = _Items.FirstOrDefault(i => i.Code == code);
        if (item != null) 
            _Items.Remove(item);
    }

    public virtual void Clear() { _Items.Clear(); UpdateUi = null; }
    protected virtual decimal Sum => _Items.Sum(i => i.Price * i.Quantity);
    public bool ValidQuantity => _Items.Count != 0;
    public decimal Price => Math.Round(Sum, 2);
    public virtual int DefaultQuantity => 0;
    public virtual bool ValidTransaction => true;
    public virtual string Name => "Base";
}
public class CashRetail : CheckoutBase
{
    private decimal _PaidAmount = 0;
    private bool _LoyaltyCard = false;
    private bool _Delivery = false;
    private NumericUpDown paidAmount;
    private CheckBox loyaltyCard;
    private CheckBox delivery;
    public CashRetail()
    {
        paidAmount = new NumericUpDown() { Minimum = 0m, Maximum = 999999m, DecimalPlaces = 2, 
            Increment = 10m, Value = 1m, Dock = DockStyle.Fill };
        loyaltyCard = new CheckBox() { Text = "Do you have loyalty card? (-5%)", Dock = DockStyle.Fill };
        delivery = new CheckBox() { Text = "Do you want your items to be delivered by currier? (+250)", Dock = DockStyle.Fill };
        
        loyaltyCard.CheckedChanged += (s, e) => { _LoyaltyCard = loyaltyCard.Checked; Update(); };
        delivery.CheckedChanged += (s, e) => { _Delivery = delivery.Checked; Update(); };
        paidAmount.ValueChanged += (s, e) => { _PaidAmount = paidAmount.Value; Update(); };

        for (int i = 0; i < 3; i++)
            _Layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        _Layout.Controls.Add(loyaltyCard, 0, 0);
        _Layout.Controls.Add(delivery, 0, 1);
        _Layout.Controls.Add(paidAmount, 0, 2);
    }
    public override void Clear()
    {
        base.Clear();
        _PaidAmount = 0;
        loyaltyCard.Checked = false;
        delivery.Checked = false;
    }
    protected override decimal Sum => base.Sum * (_LoyaltyCard ? 0.95m : 1) + (_Delivery ? 250m : 0);
    public decimal Change => _PaidAmount - Price;
    public override bool ValidTransaction => (Price <= _PaidAmount);
    public override int DefaultQuantity => 1;
    public override string Name => "Cash Retail";
}

public class CardRetail : CheckoutBase
{
}

public class DeliveryRetail : CheckoutBase
{
}

public class CashWholesale : CashRetail
{
}

public class CardWholesale : CardRetail
{
}

public class DeliveryWholesale : DeliveryRetail
{
}
