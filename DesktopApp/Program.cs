using System.ComponentModel;
using System.Diagnostics;

namespace DesktopApp;

static class Data { public static List<Item> Items = new List<Item> {
        // Fruits
        new Item("Bananas 1 kg", 50.99m, "Fruits"),
        new Item("Fuji Apples 1 kg", 135.99m, "Fruits"),
        new Item("Ginger Gold Apples 1 kg", 140.99m, "Fruits"),
        new Item("Orange Juice 1 l", 65.99m, "Fruits"),
        new Item("Tomatoes 1 kg", 40.99m, "Fruits"),
        new Item("Mandarins 1 kg", 55.99m, "Fruits"),
        new Item("Strawberries 500 g", 120.99m, "Fruits"),
        new Item("Blueberries 200 g", 160.99m, "Fruits"),
        new Item("Grapes 1 kg", 150.99m, "Fruits"),
        new Item("Lemons 1 kg", 60.99m, "Fruits"),

        // Vegetables
        new Item("Cucumber 1 kg", 34.99m, "Vegetables"),
        new Item("Potatoes 2 kg", 55.99m, "Vegetables"),
        new Item("Carrots 1 kg", 42.99m, "Vegetables"),
        new Item("Onions 1 kg", 30.99m, "Vegetables"),
        new Item("Garlic 200 g", 25.99m, "Vegetables"),
        new Item("Bell Peppers 1 kg", 95.99m, "Vegetables"),
        new Item("Broccoli 1 kg", 115.99m, "Vegetables"),
        new Item("Cauliflower 1 kg", 120.99m, "Vegetables"),
        new Item("Spinach 500 g", 80.99m, "Vegetables"),
        new Item("Lettuce 1 pc", 35.99m, "Vegetables"),

        // Meat
        new Item("Pork ribs 1 kg", 121.99m, "Meat"),
        new Item("Pork shank 1 kg", 172.99m, "Meat"),
        new Item("Chicken thigh 1 kg", 115.99m, "Meat"),
        new Item("Bacon 200 g", 112.99m, "Meat"),
        new Item("Beef Steak 1 kg", 299.99m, "Meat"),
        new Item("Ground Beef 500 g", 150.99m, "Meat"),
        new Item("Chicken Breast 1 kg", 130.99m, "Meat"),
        new Item("Sausages 500 g", 90.99m, "Meat"),
        new Item("Ham 200 g", 75.99m, "Meat"),
        new Item("Turkey Fillet 500 g", 120.99m, "Meat"),

        // Seafood
        new Item("Salmon Fillet 500 g", 245.99m, "Seafood"),
        new Item("Cod Fillet 500 g", 220.99m, "Seafood"),
        new Item("Shrimp 500 g", 350.99m, "Seafood"),
        new Item("Tuna 200 g", 180.99m, "Seafood"),
        new Item("Smoked Salmon 100 g", 125.99m, "Seafood"),

        // Dairy
        new Item("Milk 1.5% fat 1 l", 50.99m, "Dairy"),
        new Item("Cheddar Cheese 200 g", 89.99m, "Dairy"),
        new Item("Butter 200 g", 78.99m, "Dairy"),
        new Item("Yogurt 1 l", 33.99m, "Dairy"),
        new Item("Cottage Cheese 200 g", 65.99m, "Dairy"),
        new Item("Cream 250 ml", 55.99m, "Dairy"),
        new Item("Mozzarella 125 g", 75.99m, "Dairy"),
        new Item("Sour Cream 200 g", 45.99m, "Dairy"),
        new Item("Eggs 10 pcs", 80.99m, "Dairy"),
        new Item("Feta Cheese 200 g", 95.99m, "Dairy"),
        new Item("White cat 3.5 l", 300.99m, "Dairy"),

        // Snacks & Baking
        new Item("Canned beans 350 g", 60.99m, "Other"),
        new Item("Chips Paprika 150 g", 160.99m, "Snacks"),
        new Item("Salted peanuts 150 g", 54.99m, "Snacks"),
        new Item("Spaghetti 500 g", 45.99m, "Other"),
        new Item("White Bread 500 g", 22.99m, "Other"),
        new Item("Sugar 1 kg", 27.99m, "Cooking"),
        new Item("Salt 500 g", 19.99m, "Cooking"),
        new Item("Flour 1 kg", 35.99m, "Cooking"),
        new Item("Oats 500 g", 45.99m, "Cooking"),
        new Item("Rice 1 kg", 60.99m, "Cooking"),
        new Item("Pasta 500 g", 50.99m, "Cooking"),
        new Item("Biscuits 200 g", 55.99m, "Snacks"),
        new Item("Chocolate Bar 100 g", 75.99m, "Snacks"),
        new Item("Peanut Butter 250 g", 125.99m, "Cooking"),
        new Item("Honey 250 g", 145.99m, "Cooking"),
        new Item("Jam 200 g", 90.99m, "Cooking"),

        // Drinks
        new Item("Wheat Beer 0.5 l", 90.99m, "Drinks"),
        new Item("Golden Whiskey 0.2 l", 170.99m, "Drinks"),
        new Item("CocaCola 1 l", 75.99m, "Drinks"),
        new Item("Coffee 250 g", 150.99m, "Drinks"),
        new Item("Tea 100 g", 99.99m, "Drinks"),
        new Item("Cat 4.1 l", 500.99m, "Drinks"),
        new Item("Mineral Water 1.5 l", 35.99m, "Drinks"),
        new Item("Orange Soda 1 l", 50.99m, "Drinks"),
        new Item("Apple Juice 1 l", 65.99m, "Drinks"),
        new Item("Red Wine 0.75 l", 250.99m, "Drinks"),
        new Item("White Wine 0.75 l", 245.99m, "Drinks"),
        new Item("Energy Drink 0.5 l", 120.99m, "Drinks"),
        new Item("Milkshake 1 l", 150.99m, "Drinks"),

        // Cooking & Oils
        new Item("Olive Oil 1 l", 210.99m, "Cooking"),
        new Item("Tomato Ketchup 500 g", 75.99m, "Cooking"),
        new Item("Mayonnaise 500 g", 80.99m, "Cooking"),
        new Item("Sunflower Oil 1 l", 190.99m, "Cooking"),
        new Item("Vinegar 500 ml", 55.99m, "Cooking"),
        new Item("Soy Sauce 250 ml", 65.99m, "Cooking"),
        new Item("Spices Set 50 g", 120.99m, "Cooking"),

        // Frozen Food
        new Item("Frozen Pizza 450 g", 199.99m, "Other"),
        new Item("Ice Cream 1 l", 180.99m, "Other"),
        new Item("Frozen Vegetables 1 kg", 130.99m, "Other"),
        new Item("Frozen Fish Sticks 500 g", 150.99m, "Other"),
        new Item("Frozen Meatballs 500 g", 170.99m, "Other"),

        // Pets
        new Item("Cat Food 1 kg", 120.99m, "Other"),
        new Item("Dog Food 1 kg", 125.99m, "Other"),
        new Item("Bird Seed 500 g", 45.99m, "Other"),
        new Item("Fish Flakes 200 g", 35.99m, "Other"),

        // Household
        new Item("Paper Towels 2-pack", 99.99m, "Household"),
        new Item("Laundry Detergent 2 kg", 299.99m, "Household"),
        new Item("Dish Soap 500 ml", 55.99m, "Household"),
        new Item("Trash Bags 30 pcs", 75.99m, "Household"),
        new Item("Cleaning Spray 500 ml", 120.99m, "Household"),
        new Item("Sponge Set 5 pcs", 35.99m, "Household"),
        new Item("Air Freshener 300 ml", 99.99m, "Household"),

        // Personal Care
        new Item("Shampoo 500 ml", 220.99m, "Personal Care"),
        new Item("Toothpaste 75 ml", 65.99m, "Personal Care"),
        new Item("Toothbrush 1 pc", 45.99m, "Personal Care"),
        new Item("Soap 100 g", 25.99m, "Personal Care"),
        new Item("Lotion 200 ml", 150.99m, "Personal Care"),
        new Item("Deodorant 150 ml", 130.99m, "Personal Care"),
        new Item("Shaving Foam 200 ml", 140.99m, "Personal Care"),
        new Item("Face Cream 50 ml", 199.99m, "Personal Care")
    }; }
public static class Supermarket
{
    public static string name = "Le Silpo";
    public static string Adress = "21 Jump Street";
    public static string JuridicalNumber = "70176892";
    public static bool Cash = true;
    public static bool Online = true;
    public static bool Delivery = true;
    public static bool CashOnDelivery = true;
    public static Dictionary<string, CheckoutBase> Machines = new Dictionary<string, CheckoutBase>();
    public static List<Item> Items = new List<Item>();
    private static List<Transaction> Transactions = new List<Transaction>();
    public static void SaveToFile() { }
    public static void LoadFromFile() { }
    public static void SaveTransactions() { }
    public static void AddCheckout(CheckoutBase checkout) => Machines.TryAdd(checkout.Name, checkout);
    public static void DeleteCheckout(string name) => Machines.Remove(name);
    public static void AddItem(Item item)
    {
        if (Items.FirstOrDefault(i => i.Code == item.Code) is Item existing)
        { existing.Quantity += item.Quantity; return; }

        if (String.IsNullOrWhiteSpace(item.Name) || String.IsNullOrWhiteSpace(item.Category) || item.Price <= 0)
        { MessageBox.Show("Invalid input", "Error"); return; }
        
        if (!Categories.Any(i => i == item.Category))
            Categories.Add(item.Category);
        
        item.Code = Items.Count + 100000;
        Items.Add(item);
    }
    public static void StockUp(int code, int quantity) => Items.First(i => i.Code == code).Quantity += quantity;
    public static void addTransaction(Transaction transaction) =>  Transactions.Add(transaction);
    public static List<Transaction> getTransactions() => Transactions;

    public static List<string> Categories = new List<String>();
}
public class Transaction(DateTime date, decimal amount, string mode)
{
    public string Mode { get; init; } = mode;
    public DateTime Date { get; init; } = date;
    public decimal Amount { get; init; } = amount;
}
public class Item(string name, decimal price, string category, int quantity = 0, int code = 0)
{
    public string Name { get; init; } = name;
    public decimal Price { get; init; } = price;
    public string Category { get; init; } = category;
    public int Code { get; set; } = code;
    public int Quantity { get; set; } = quantity;
}
static class Program
{
    [STAThread]
    static void Main()
    {
        foreach (var item in Data.Items) Supermarket.AddItem(item);
        
        
        ApplicationConfiguration.Initialize();
        Application.Run(new ControlPanel());
    }
}
