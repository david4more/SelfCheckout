using System.ComponentModel;

namespace DesktopApp;

public static class Data
{
    public static bool Cash = true;
    public static bool Online = true;
    public static bool Delivery = true;
    public static bool CashOnDelivery = true;
    public static string Adress = "21 Jump Street";
    
    public static List<Item> Items = new List<Item>
    {
        // Fruits
        new Item("Bananas 1 kg", 50.99m, 345872, "Fruits"),
        new Item("Fuji Apples 1 kg", 135.99m, 918264, "Fruits"),
        new Item("Ginger Gold Apples 1 kg", 140.99m, 762309, "Fruits"),
        new Item("Orange Juice 1 l", 65.99m, 487215, "Fruits"),
        new Item("Tomatoes 1 kg", 40.99m, 639801, "Fruits"),
        new Item("Mandarins 1 kg", 55.99m, 582913, "Fruits"),
        new Item("Strawberries 500 g", 120.99m, 704182, "Fruits"),
        new Item("Blueberries 200 g", 160.99m, 891476, "Fruits"),
        new Item("Grapes 1 kg", 150.99m, 237195, "Fruits"),
        new Item("Lemons 1 kg", 60.99m, 476392, "Fruits"),

        // Vegetables
        new Item("Cucumber 1 kg", 34.99m, 928571, "Vegetables"),
        new Item("Potatoes 2 kg", 55.99m, 317640, "Vegetables"),
        new Item("Carrots 1 kg", 42.99m, 564231, "Vegetables"),
        new Item("Onions 1 kg", 30.99m, 710482, "Vegetables"),
        new Item("Garlic 200 g", 25.99m, 856924, "Vegetables"),
        new Item("Bell Peppers 1 kg", 95.99m, 103785, "Vegetables"),
        new Item("Broccoli 1 kg", 115.99m, 924681, "Vegetables"),
        new Item("Cauliflower 1 kg", 120.99m, 487263, "Vegetables"),
        new Item("Spinach 500 g", 80.99m, 652194, "Vegetables"),
        new Item("Lettuce 1 pc", 35.99m, 391527, "Vegetables"),

        // Meat
        new Item("Pork ribs 1 kg", 121.99m, 864239, "Meat"),
        new Item("Pork shank 1 kg", 172.99m, 395874, "Meat"),
        new Item("Chicken thigh 1 kg", 115.99m, 247386, "Meat"),
        new Item("Bacon 200 g", 112.99m, 758194, "Meat"),
        new Item("Beef Steak 1 kg", 299.99m, 684215, "Meat"),
        new Item("Ground Beef 500 g", 150.99m, 391762, "Meat"),
        new Item("Chicken Breast 1 kg", 130.99m, 572846, "Meat"),
        new Item("Sausages 500 g", 90.99m, 104938, "Meat"),
        new Item("Ham 200 g", 75.99m, 836295, "Meat"),
        new Item("Turkey Fillet 500 g", 120.99m, 719482, "Meat"),

        // Seafood
        new Item("Salmon Fillet 500 g", 245.99m, 915273, "Seafood"),
        new Item("Cod Fillet 500 g", 220.99m, 683914, "Seafood"),
        new Item("Shrimp 500 g", 350.99m, 492178, "Seafood"),
        new Item("Tuna 200 g", 180.99m, 276394, "Seafood"),
        new Item("Smoked Salmon 100 g", 125.99m, 804291, "Seafood"),

        // Dairy
        new Item("Milk 1.5% fat 1 l", 50.99m, 192847, "Dairy"),
        new Item("Cheddar Cheese 200 g", 89.99m, 384719, "Dairy"),
        new Item("Butter 200 g", 78.99m, 572493, "Dairy"),
        new Item("Yogurt 1 l", 33.99m, 918472, "Dairy"),
        new Item("Cottage Cheese 200 g", 65.99m, 647182, "Dairy"),
        new Item("Cream 250 ml", 55.99m, 731598, "Dairy"),
        new Item("Mozzarella 125 g", 75.99m, 294817, "Dairy"),
        new Item("Sour Cream 200 g", 45.99m, 583291, "Dairy"),
        new Item("Eggs 10 pcs", 80.99m, 476182, "Dairy"),
        new Item("Feta Cheese 200 g", 95.99m, 182947, "Dairy"),
        new Item("White cat 3.5 l", 300.99m, 729184, "Dairy"),

        // Snacks & Baking
        new Item("Canned beans 350 g", 60.99m, 918362, "Other"),
        new Item("Chips Paprika 150 g", 160.99m, 472591, "Snacks"),
        new Item("Salted peanuts 150 g", 54.99m, 736194, "Snacks"),
        new Item("Spaghetti 500 g", 45.99m, 284719, "Other"),
        new Item("White Bread 500 g", 22.99m, 193847, "Other"),
        new Item("Sugar 1 kg", 27.99m, 584921, "Cooking"),
        new Item("Salt 500 g", 19.99m, 472813, "Cooking"),
        new Item("Flour 1 kg", 35.99m, 692184, "Cooking"),
        new Item("Oats 500 g", 45.99m, 581294, "Cooking"),
        new Item("Rice 1 kg", 60.99m, 473918, "Cooking"),
        new Item("Pasta 500 g", 50.99m, 392871, "Cooking"),
        new Item("Biscuits 200 g", 55.99m, 164839, "Snacks"),
        new Item("Chocolate Bar 100 g", 75.99m, 582193, "Snacks"),
        new Item("Peanut Butter 250 g", 125.99m, 471823, "Cooking"),
        new Item("Honey 250 g", 145.99m, 736294, "Cooking"),
        new Item("Jam 200 g", 90.99m, 284716, "Cooking"),

        // Drinks
        new Item("Wheat Beer 0.5 l", 90.99m, 917384, "Drinks"),
        new Item("Golden Whiskey 0.2 l", 170.99m, 284719, "Drinks"),
        new Item("CocaCola 1 l", 75.99m, 652381, "Drinks"),
        new Item("Coffee 250 g", 150.99m, 471928, "Drinks"),
        new Item("Tea 100 g", 99.99m, 293847, "Drinks"),
        new Item("Cat 4.1 l", 500.99m, 138294, "Drinks"),
        new Item("Mineral Water 1.5 l", 35.99m, 527381, "Drinks"),
        new Item("Orange Soda 1 l", 50.99m, 918273, "Drinks"),
        new Item("Apple Juice 1 l", 65.99m, 384729, "Drinks"),
        new Item("Red Wine 0.75 l", 250.99m, 472918, "Drinks"),
        new Item("White Wine 0.75 l", 245.99m, 183947, "Drinks"),
        new Item("Energy Drink 0.5 l", 120.99m, 927384, "Drinks"),
        new Item("Milkshake 1 l", 150.99m, 583917, "Drinks"),

        // Cooking & Oils
        new Item("Olive Oil 1 l", 210.99m, 384719, "Cooking"),
        new Item("Tomato Ketchup 500 g", 75.99m, 193847, "Cooking"),
        new Item("Mayonnaise 500 g", 80.99m, 472918, "Cooking"),
        new Item("Sunflower Oil 1 l", 190.99m, 581294, "Cooking"),
        new Item("Vinegar 500 ml", 55.99m, 384291, "Cooking"),
        new Item("Soy Sauce 250 ml", 65.99m, 472361, "Cooking"),
        new Item("Spices Set 50 g", 120.99m, 918274, "Cooking"),

        // Frozen Food
        new Item("Frozen Pizza 450 g", 199.99m, 573918, "Other"),
        new Item("Ice Cream 1 l", 180.99m, 381947, "Other"),
        new Item("Frozen Vegetables 1 kg", 130.99m, 294817, "Other"),
        new Item("Frozen Fish Sticks 500 g", 150.99m, 918273, "Other"),
        new Item("Frozen Meatballs 500 g", 170.99m, 384729, "Other"),

        // Pets
        new Item("Cat Food 1 kg", 120.99m, 582193, "Other"),
        new Item("Dog Food 1 kg", 125.99m, 471823, "Other"),
        new Item("Bird Seed 500 g", 45.99m, 736294, "Other"),
        new Item("Fish Flakes 200 g", 35.99m, 284716, "Other"),

        // Household
        new Item("Paper Towels 2-pack", 99.99m, 918273, "Household"),
        new Item("Laundry Detergent 2 kg", 299.99m, 384729, "Household"),
        new Item("Dish Soap 500 ml", 55.99m, 472918, "Household"),
        new Item("Trash Bags 30 pcs", 75.99m, 193847, "Household"),
        new Item("Cleaning Spray 500 ml", 120.99m, 581294, "Household"),
        new Item("Sponge Set 5 pcs", 35.99m, 384291, "Household"),
        new Item("Air Freshener 300 ml", 99.99m, 472361, "Household"),

        // Personal Care
        new Item("Shampoo 500 ml", 220.99m, 918274, "Personal Care"),
        new Item("Toothpaste 75 ml", 65.99m, 293847, "Personal Care"),
        new Item("Toothbrush 1 pc", 45.99m, 384729, "Personal Care"),
        new Item("Soap 100 g", 25.99m, 918273, "Personal Care"),
        new Item("Lotion 200 ml", 150.99m, 384291, "Personal Care"),
        new Item("Deodorant 150 ml", 130.99m, 472361, "Personal Care"),
        new Item("Shaving Foam 200 ml", 140.99m, 918274, "Personal Care"),
        new Item("Face Cream 50 ml", 199.99m, 581294, "Personal Care")
    };
    public static List<String> Categories = new List<String>
    {
        "Fruits", "Vegetables", "Meat", "Seafood", "Snacks", "Dairy", "Drinks", "Other", "Cooking", "Household", "Personal Care"
    };
    
    static List<Transaction> Transactions = new List<Transaction>();
    public static void addTransaction(Transaction transaction) =>  Transactions.Add(transaction);
    public static List<Transaction> getTransactions() => Transactions;
}
public class Transaction(DateTime date, decimal amount, string mode)
{
    public string Mode { get; init; } = mode;
    public DateTime Date { get; init; } = date;
    public decimal Amount { get; init; } = amount;
}
public class Item(string name, decimal price, int code, string category, int quantity = 0)
{
    public string Name { get; init; } = name;
    public decimal Price { get; init; } = price;
    public string Category { get; init; } = category;
    public int Code { get; init; } = code;
    public int Quantity { get; set; } = quantity;
}
static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());

        
    }
}