namespace DesktopApp;

public class Item(string name, decimal price, int code, string category)
{
    public string Name { get; init; } = name;
    public decimal Price { get; init; } = price;
    public int Code { get; init; } = code;
    public string Category { get; init; } = category;
}

public static class Checkout
{
    public static List<Item> Items = new List<Item>
    {
        // Fruits
        new Item("Bananas 1 kg", 50.99m, 591723, "Fruits"),
        new Item("Fuji Apples 1 kg", 135.99m, 296720, "Fruits"),
        new Item("Ginger Gold Apples 1 kg", 140.99m, 929763, "Fruits"),
        new Item("Orange Juice 1 l", 65.99m, 104582, "Fruits"),
        new Item("Tomatoes 1 kg", 40.99m, 072198, "Fruits"),
        new Item("Mandarins 1 kg", 55.99m, 100001, "Fruits"),
        new Item("Strawberries 500 g", 120.99m, 100002, "Fruits"),
        new Item("Blueberries 200 g", 160.99m, 100003, "Fruits"),
        new Item("Grapes 1 kg", 150.99m, 100004, "Fruits"),
        new Item("Lemons 1 kg", 60.99m, 100005, "Fruits"),

        // Vegetables
        new Item("Cucumber 1 kg", 34.99m, 296481, "Vegetables"),
        new Item("Potatoes 2 kg", 55.99m, 329716, "Vegetables"),
        new Item("Carrots 1 kg", 42.99m, 087234, "Vegetables"),
        new Item("Onions 1 kg", 30.99m, 100006, "Vegetables"),
        new Item("Garlic 200 g", 25.99m, 100007, "Vegetables"),
        new Item("Bell Peppers 1 kg", 95.99m, 100008, "Vegetables"),
        new Item("Broccoli 1 kg", 115.99m, 100009, "Vegetables"),
        new Item("Cauliflower 1 kg", 120.99m, 100010, "Vegetables"),
        new Item("Spinach 500 g", 80.99m, 100011, "Vegetables"),
        new Item("Lettuce 1 pc", 35.99m, 100012, "Vegetables"),

        // Meat
        new Item("Pork ribs 1 kg", 121.99m, 917569, "Meat"),
        new Item("Pork shank 1 kg", 172.99m, 672062, "Meat"),
        new Item("Chicken thigh 1 kg", 115.99m, 296715, "Meat"),
        new Item("Bacon 200 g", 112.99m, 476893, "Meat"),
        new Item("Beef Steak 1 kg", 299.99m, 100013, "Meat"),
        new Item("Ground Beef 500 g", 150.99m, 100014, "Meat"),
        new Item("Chicken Breast 1 kg", 130.99m, 100015, "Meat"),
        new Item("Sausages 500 g", 90.99m, 100016, "Meat"),
        new Item("Ham 200 g", 75.99m, 100017, "Meat"),
        new Item("Turkey Fillet 500 g", 120.99m, 100018, "Meat"),

        // Seafood
        new Item("Salmon Fillet 500 g", 245.99m, 913274, "Seafood"),
        new Item("Cod Fillet 500 g", 220.99m, 100019, "Seafood"),
        new Item("Shrimp 500 g", 350.99m, 100020, "Seafood"),
        new Item("Tuna 200 g", 180.99m, 100021, "Seafood"),
        new Item("Smoked Salmon 100 g", 125.99m, 100022, "Seafood"),

        // Dairy
        new Item("Milk 1.5% fat 1 l", 50.99m, 179015, "Dairy"),
        new Item("Cheddar Cheese 200 g", 89.99m, 502317, "Dairy"),
        new Item("Butter 200 g", 78.99m, 978123, "Dairy"),
        new Item("Yogurt 1 l", 33.99m, 129384, "Dairy"),
        new Item("Cottage Cheese 200 g", 65.99m, 100023, "Dairy"),
        new Item("Cream 250 ml", 55.99m, 100024, "Dairy"),
        new Item("Mozzarella 125 g", 75.99m, 100025, "Dairy"),
        new Item("Sour Cream 200 g", 45.99m, 100026, "Dairy"),
        new Item("Eggs 10 pcs", 80.99m, 100027, "Dairy"),
        new Item("Feta Cheese 200 g", 95.99m, 100028, "Dairy"),
        new Item("White cat 3.5 l", 300.99m, 102728, "Dairy"),

        // Snacks & Baking
        new Item("Canned beans 350 g", 60.99m, 105897, "Other"),
        new Item("Chips Paprika 150 g", 160.99m, 529304, "Snacks"),
        new Item("Salted peanuts 150 g", 54.99m, 071233, "Snacks"),
        new Item("Spaghetti 500 g", 45.99m, 078962, "Other"),
        new Item("White Bread 500 g", 22.99m, 529176, "Other"),
        new Item("Sugar 1 kg", 27.99m, 394812, "Cooking"),
        new Item("Salt 500 g", 19.99m, 608217, "Cooking"),
        new Item("Flour 1 kg", 35.99m, 100029, "Cooking"),
        new Item("Oats 500 g", 45.99m, 100030, "Cooking"),
        new Item("Rice 1 kg", 60.99m, 100031, "Cooking"),
        new Item("Pasta 500 g", 50.99m, 100032, "Cooking"),
        new Item("Biscuits 200 g", 55.99m, 100033, "Snacks"),
        new Item("Chocolate Bar 100 g", 75.99m, 100034, "Snacks"),
        new Item("Peanut Butter 250 g", 125.99m, 100035, "Cooking"),
        new Item("Honey 250 g", 145.99m, 100036, "Cooking"),
        new Item("Jam 200 g", 90.99m, 100037, "Cooking"),

        // Drinks
        new Item("Wheat Beer 0.5 l", 90.99m, 097213, "Drinks"),
        new Item("Golden Whiskey 0.2 l", 170.99m, 572893, "Drinks"),
        new Item("CocaCola 1 l", 75.99m, 198723, "Drinks"),
        new Item("Coffee 250 g", 150.99m, 081927, "Drinks"),
        new Item("Tea 100 g", 99.99m, 470238, "Drinks"),
        new Item("Cat 4.1 l", 500.99m, 012984, "Drinks"),
        new Item("Mineral Water 1.5 l", 35.99m, 100038, "Drinks"),
        new Item("Orange Soda 1 l", 50.99m, 100039, "Drinks"),
        new Item("Apple Juice 1 l", 65.99m, 100040, "Drinks"),
        new Item("Red Wine 0.75 l", 250.99m, 100041, "Drinks"),
        new Item("White Wine 0.75 l", 245.99m, 100042, "Drinks"),
        new Item("Energy Drink 0.5 l", 120.99m, 100043, "Drinks"),
        new Item("Milkshake 1 l", 150.99m, 100044, "Drinks"),

        // Cooking & Oils
        new Item("Olive Oil 1 l", 210.99m, 471982, "Cooking"),
        new Item("Tomato Ketchup 500 g", 75.99m, 333444, "Cooking"),
        new Item("Mayonnaise 500 g", 80.99m, 333445, "Cooking"),
        new Item("Sunflower Oil 1 l", 190.99m, 100045, "Cooking"),
        new Item("Vinegar 500 ml", 55.99m, 100046, "Cooking"),
        new Item("Soy Sauce 250 ml", 65.99m, 100047, "Cooking"),
        new Item("Spices Set 50 g", 120.99m, 100048, "Cooking"),

        // Frozen Food
        new Item("Frozen Pizza 450 g", 199.99m, 555666, "Other"),
        new Item("Ice Cream 1 l", 180.99m, 555667, "Other"),
        new Item("Frozen Vegetables 1 kg", 130.99m, 100049, "Other"),
        new Item("Frozen Fish Sticks 500 g", 150.99m, 100050, "Other"),
        new Item("Frozen Meatballs 500 g", 170.99m, 100051, "Other"),

        // Pets
        new Item("Cat Food 1 kg", 120.99m, 999000, "Other"),
        new Item("Dog Food 1 kg", 125.99m, 100052, "Other"),
        new Item("Bird Seed 500 g", 45.99m, 100053, "Other"),
        new Item("Fish Flakes 200 g", 35.99m, 100054, "Other"),

        // Household
        new Item("Paper Towels 2-pack", 99.99m, 100055, "Household"),
        new Item("Laundry Detergent 2 kg", 299.99m, 100056, "Household"),
        new Item("Dish Soap 500 ml", 55.99m, 100057, "Household"),
        new Item("Trash Bags 30 pcs", 75.99m, 100058, "Household"),
        new Item("Cleaning Spray 500 ml", 120.99m, 100059, "Household"),
        new Item("Sponge Set 5 pcs", 35.99m, 100060, "Household"),
        new Item("Air Freshener 300 ml", 99.99m, 100061, "Household"),

        // Personal Care
        new Item("Shampoo 500 ml", 220.99m, 100062, "Personal Care"),
        new Item("Toothpaste 75 ml", 65.99m, 100063, "Personal Care"),
        new Item("Toothbrush 1 pc", 45.99m, 100064, "Personal Care"),
        new Item("Soap 100 g", 25.99m, 100065, "Personal Care"),
        new Item("Lotion 200 ml", 150.99m, 100066, "Personal Care"),
        new Item("Deodorant 150 ml", 130.99m, 100067, "Personal Care"),
        new Item("Shaving Foam 200 ml", 140.99m, 100068, "Personal Care"),
        new Item("Face Cream 50 ml", 199.99m, 100069, "Personal Care")
    };

    public static List<String> Categories = new List<String>
    {
        "Fruits", "Vegetables", "Meat", "Seafood", "Snacks", "Diary", "Drinks", "Other", "Cooking", "Household", "Personal Care"
    };
}

struct CashRetail
{
    public List<Item> Items;
    public decimal PaidAmount;
    public bool LoyaltyCard;
    public bool HomeDelivery;

    public decimal TotalPrice => Items.Sum(i => i.Price) * (LoyaltyCard ? 0.95m : 1) + (HomeDelivery ? 250m : 0);
    public decimal Change => PaidAmount - TotalPrice;
    public bool ValidTransaction => (Items != null && Items.Count != 0 && TotalPrice <= PaidAmount);
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

        
    }
}