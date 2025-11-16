namespace DesktopApp;

struct CashRetail
{
    public List<Item> Items;
    public decimal PaidAmount;
    public bool LoyaltyCard;
    public bool HomeDelivery;

    public decimal TotalPrice => Items.Sum(i => i.price) * (LoyaltyCard ? 0.95m : 1) + (HomeDelivery ? 250m : 0);
    public decimal Change => PaidAmount - TotalPrice;

    public bool ValidateTransaction()
    {
        return (Items != null && Items.Count != 0 && TotalPrice <= PaidAmount);
    }
}

struct CardRetail
{
}

struct DeliveryRetail
{
}

struct CashWholesale
{
}

struct CardWholesale
{
}

struct DeliveryWholesale
{
}



static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());

        CashRetail r = new CashRetail();

        
    }
}