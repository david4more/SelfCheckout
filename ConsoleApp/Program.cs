
public class Item(string name, decimal price, int code)
{
    public string name = name;
    public decimal price = price;
    public int code = code;
}

public static class Utils
{
    public static string ReadLine(HashSet<string> expectedInputs, string textOnFail)
    {
        Console.WriteLine(textOnFail);
        while (true)
        {
            Console.Write(">> ");
            var str = Console.ReadLine();
            if (expectedInputs.Contains(str))
                return str;

            Console.WriteLine("Invalid input. " + textOnFail);
        }
    }
}

public class Checkout(int checkoutNumber, string model, List<Item> Items)
{
    // fields
    private int checkoutNumber = checkoutNumber;
    private decimal money;
    private string model = model;
    private List<Item> Items = Items;
    private List<(decimal, DateTime)> transactions = new List<(decimal, DateTime)>();
    
    private bool cash;
    private bool online;
    private bool delivery;
    private bool cashOnDelivery;
    private string adress;

    // helper functions
    private void CashierPassword()
    {
        Console.WriteLine("Type in cashier's password:");
        Utils.ReadLine(["123456"], "Hint: 12****");
    }
    private decimal WriteItems(List<int> pickedUnits)
    {
        decimal total = 0;
        Console.WriteLine("Picked units:");
        for(int i = 0; i < pickedUnits.Count; i++)
        {
            int index = pickedUnits[i];
            Console.WriteLine(Items[index].name + " - " + Items[index].price + " UAH");
            total += Items[index].price;
        }
        Console.WriteLine("Total: " + total + " UAH");
        return total;
    }
    
    private void CompleteTransation(decimal amount)
    {
        if (money + amount < 0)
        {
            Console.WriteLine("Error: not enough money in machine");
            return;
        }

        money += amount;
        transactions.Add((amount, DateTime.Now));
        Console.WriteLine("Transaction completed - " + DateTime.Now);
    }

    // public methods
    public void Deposit()
    {
        CashierPassword();
        Console.WriteLine("Current money: " + money + " UAH. Enter the amount you want to deposit:");
        Console.Write(">> ");
        var str  = Console.ReadLine();
        if (!decimal.TryParse(str, out var amount))
        {
            Console.WriteLine("Invalid amount.");
            return;
        }
        else
        {
            CompleteTransation(amount);
            Console.WriteLine("You deposited: " + amount + " UAH, new balance: " + money + " UAH.");
        }
    }
    public void Withdraw()
    {
        CashierPassword();
        Console.WriteLine("Current money: " + money + " UAH. Enter the amount you want to withdraw:");
        Console.Write(">> ");
        var str  = Console.ReadLine();
        if (!decimal.TryParse(str, out var amount))
        {
            Console.WriteLine("Invalid amount.");
            return;
        }
        if (amount <= money)
        {
            CompleteTransation(-amount);
            Console.WriteLine("You withdrew: " + amount + " UAH, new balance: " + money + " UAH.");
        }
        else
            Console.WriteLine("Insufficient funds. (" + money + " UAH in machine)");
    }
    public void WriteTransactions()
    {
        CashierPassword();
        foreach (var t in transactions)
            Console.WriteLine(t.Item1 + " UAH - " +  t.Item2);
    }
    public void AddItem()
    {
        CashierPassword();
        Console.WriteLine("Type in item's name and weight/volume:");
        Console.Write(">> ");
        string? ItemName = Console.ReadLine();
        Console.WriteLine("Type in item's price:");
        Console.Write(">> ");
        var ItemPrice = Console.ReadLine();
        Console.WriteLine("Type in item's code:");
        Console.Write(">> ");
        var ItemCode = Console.ReadLine();

        if (string.IsNullOrEmpty(ItemName) || !decimal.TryParse(ItemPrice, out var price) || !int.TryParse(ItemCode, out var code))
            Console.WriteLine("Invalid input");
        else
        {
            foreach(var p in Items)
            {
                if (p.code == code)
                {
                    Console.WriteLine("Code already exists\nProcedure canceled");
                    return;
                }
            }
            Items.Add(new Item(ItemName, price, code));
            Console.WriteLine("Item added!");
        }
    }
    public void Transaction()
    {
        if (Items.Count == 0)
        {
            Console.WriteLine("No Items available.");
            return;
        }
        List<int> pickedUnits = new List<int>();
        int lastPage = (int)Math.Ceiling(Items.Count / 10.0) - 1;
        int page = 0, firstUnit = 0, lastUnit = 0;
        void UpdateLastUnit() => lastUnit = (Items.Count - 1 - firstUnit < 10) ? Items.Count : firstUnit + 10;
        UpdateLastUnit();
        var loop = true;
        while (loop)
        {
            WriteItems(pickedUnits);
            Console.WriteLine("Page: " + (page + 1) + '/' + (lastPage + 1));
            string message = "Type index of picked item, ";
            bool start = (page == 0), end = (page == lastPage);
            if (!end)
                message += "> - next page, ";
            if (!start)
                message += "< - previous page, ";
            message += " e - exit, c - clear, p - proceed:";

            for (int i = firstUnit; i < lastUnit; i++)
                Console.WriteLine((i + 1) + ": " + Items[i].name + " - " + Items[i].price + " UAH");
            Console.WriteLine(message);

            Console.Write(">> ");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case ">":
                {
                    if (end)
                        continue;

                    firstUnit += 10;
                    UpdateLastUnit();
                    page++;
                }
                    break;
                case "<":
                {
                    if (start)
                        continue;

                    firstUnit -= 10;
                    UpdateLastUnit();
                    page--;
                }
                    break;
                case "e":
                    loop = false;
                    break;
                case "c":
                    pickedUnits.Clear();
                    break;
                case "p":
                {
                    var total = WriteItems(pickedUnits);
                    if (Utils.ReadLine(["p", "r"],"proceed - p, return - r: ") == "r") break;
                    answer = Utils.ReadLine(["1", "2"], "card - 1, cash - 2:");
                    if (answer == "1")
                    {
                        Console.WriteLine("Press card against the scanner...(press X):");
                        Utils.ReadLine(["X"], "Press X:");
                        
                        CompleteTransation(total);
                        loop = false;
                        Console.WriteLine("Have a nice day!");
                    }
                    else if (answer == "2")
                    {
                        while (true)
                        {
                            Console.WriteLine("Insert cash...(type in the amount) or cancel - c:");
                            Console.Write(">> ");
                            var  input = Console.ReadLine();
                            if (input == "c") break;
                            if (decimal.TryParse(input, out decimal amount))
                            {
                                if  (amount < total)
                                    Console.WriteLine("Not enough cash.");
                                else
                                {
                                    CompleteTransation(total);
                                    amount -= total;
                                    if (amount != 0)
                                        Console.WriteLine("Your rest: " + amount);
                                    loop = false;
                                    Console.WriteLine("Have a nice day!");
                                    break;
                                }
                            }
                            else
                                Console.WriteLine("Invalid input (" + input + ")");
                        }
                    }
                    
                }
                    break;
                default:
                {
                    if (string.IsNullOrEmpty(answer))
                        break;
                    else
                    {
                        if (int.TryParse(answer, out var pickedUnit))
                        {
                            pickedUnit--;
                            if (pickedUnit >= firstUnit && pickedUnit < lastUnit)
                                pickedUnits.Add(pickedUnit);
                        }
                    }
                }
                    break;
            }
        }
    }
}

static class Program
{
    static void Main()
    {
        // adding Items
        List<Item> Items =
        [
            new Item("Canned beans 350 g", 60.99m, 105897),
            new Item("Bananas 1 kg", 50.99m, 591723),
            new Item("Pork ribs 1 kg", 121.99m, 917569),
            new Item("Pork shank 1 kg", 172.99m, 672062),
            new Item("Chicken thigh 1 kg", 115.99m, 296715),
            new Item("Fuji Apples 1 kg", 135.99m, 296720),
            new Item("Ginger Gold Apples 1 kg", 140.99m, 929763),
            new Item("Bacon 200 g", 112.99m, 476893),
            new Item("Chips Paprika 150 g", 160.99m, 529304),
            new Item("Wheat Bear 0.5 l", 90.99m, 097213),
            new Item("Golden Whiskey 0.2 l", 170.99m, 572893),
            new Item("CocaCola 1 l", 75.99m, 198723),
            new Item("Salted peanuts 150 g", 54.99m, 071233),
            new Item("Milk 1.5% fat 1 l", 50.99m, 179015),
            new Item("Spaghetti 500 g", 45.99m, 078962),
            new Item("Cat 4.1 l", 500.99m, 012984),
            new Item("Orange Juice 1 l", 65.99m, 104582),
            new Item("Cheddar Cheese 200 g", 89.99m, 502317),
            new Item("Salmon Fillet 500 g", 245.99m, 913274),
            new Item("Tomatoes 1 kg", 40.99m, 072198),
            new Item("Cucumber 1 kg", 34.99m, 296481),
            new Item("Potatoes 2 kg", 55.99m, 329716),
            new Item("Carrots 1 kg", 42.99m, 087234),
            new Item("Olive Oil 1 l", 210.99m, 471982),
            new Item("White Bread 500 g", 22.99m, 529176),
            new Item("Butter 200 g", 78.99m, 978123),
            new Item("Yogurt 1 l", 33.99m, 129384),
            new Item("Coffee 250 g", 150.99m, 081927),
            new Item("Tea 100 g", 99.99m, 470238),
            new Item("Sugar 1 kg", 27.99m, 394812),
            new Item("Salt 500 g", 19.99m, 608217)
        ];

        // creating self-service checkout machine object
        Checkout checkout = new Checkout(4, "Mashgin", Items);

        // main loop
        var loop = true;
        while (loop)
        {
            Console.WriteLine("    Choose option:\nt - transaction,\ne- exit\n    FOR CASHIERS ONLY (password required):" +
                              "\nw - withdraw money,\nd - deposit money,\nl - list of transactions,\nn - add new Item");
            Console.Write(">> ");
            var str = Console.ReadLine();
            switch (str)
            {
                case "t":
                    checkout.Transaction();
                    break;
                case "w":
                    checkout.Withdraw();
                    break;
                case "d":
                    checkout.Deposit();
                    break;
                case "l":
                    checkout.WriteTransactions();
                    break;
                case "n":
                    checkout.AddItem();
                    break;
                case "e":
                    loop = false;
                    break;
            }
        }
    }
}