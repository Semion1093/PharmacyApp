using PharmacyApp.Menu;
using PharmacyApp.Models;
using PharmacyApp.Repositories;


bool exitApp = false;

while (!exitApp)
{
    Console.Clear();
    MainMenu.Menu();
    Console.Write("Enter the command: ");
    var command = Console.ReadLine().Trim().ToLower();
    Console.Clear();

    switch (command)
    {
        case "Exit":
        case "e":
            exitApp = true;
            break;
        case "AddProduct":
        case "ap":
            AddProduct();
            break;
        case "DeleteProduct":
        case "dp":
            DeleteProduct();
            break;
        case "AddPharmacy":
        case "aph":
            AddPharmacy();
            break;
        case "DeletePharmacy":
        case "dph":
            DeletePharmacy();
            break;
        case "AddStore":
        case "as":
            AddStore();
            break;
        case "DeleteStore":
        case "ds":
            DeleteStore();
            break;
        case "AddBatch":
        case "ab":
            AddBatch();
            break;
        case "DeleteBatch":
        case "db":
            DeleteBatch();
            break;
        case "GetAllProductsByPharmacy":
        case "get":
            GetProducts();
            break;
        case "Help":
        case "h":
            HelpMenu.Help();
            break;

        default:
            Console.Clear();
            MainMenu.Menu();
            ConsoleEx.Write("Wrong command. Press ENTER to contunue... ", ConsoleColor.Red);
            Console.ReadLine();
            break;
    }

    static void AddProduct()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Add Product", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Name: ");
        Product product = new()
        {
            Name = Console.ReadLine().Trim()
        };

        ProductRepository productRepository = new();
        var id = productRepository.AddProduct(product);

        Console.WriteLine();
        ConsoleEx.WriteLine($"{id}", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    static void DeleteProduct()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Delete Product", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        ProductRepository productRepository = new();
        productRepository.DeleteProduct(id);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Success!", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    static void AddPharmacy()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Add Pharmacy", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Name: ");
        var name = Console.ReadLine().Trim();
        Console.Write(" >> Adress: ");
        var adress = Console.ReadLine().Trim(); 
        Console.Write(" >> Phone: ");
        var phone = Console.ReadLine().Trim();
        Pharmacy pharmacy = new()
        {
            Name = name,
            Adress = adress,
            Phone = phone
        };

        PharmacyRepository pharmacyRepository = new();
        var id = pharmacyRepository.AddPharmacy(pharmacy);

        Console.WriteLine();
        ConsoleEx.WriteLine($"{id}", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }
     
    static void DeletePharmacy()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Delete Pharmacy", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        PharmacyRepository pharmacyRepository = new();
        pharmacyRepository.DeletePharmacy(id);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Success!", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    static void AddStore()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Add Store", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Name: ");
        var name = Console.ReadLine().Trim();
        Console.Write(" >> PharmacyId: ");
        int pharmacyId = Convert.ToInt32(Console.ReadLine().Trim());
        Store store = new()
        {
            Name = name,
            PharmacyId = pharmacyId
        };

        StoreRepository storeRepository = new();
        var id = storeRepository.AddStore(store);

        Console.WriteLine();
        ConsoleEx.WriteLine($"{id}", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    static void DeleteStore()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Delete Store", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        StoreRepository storeRepository = new();
        storeRepository.DeleteStore(id);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Success!", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    static void AddBatch()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Add Batch", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> ProductId: ");
        int productId = Convert.ToInt32(Console.ReadLine().Trim());
        Console.Write(" >> StoreId: ");
        int storeId = Convert.ToInt32(Console.ReadLine().Trim());
        Console.Write(" >> Count: ");
        int count = Convert.ToInt32(Console.ReadLine().Trim());
        Batch batch = new()
        {
            ProductId = productId,
            StoreId = storeId,
            Count = count
        };

        BatchRepository batchRepository = new();
        var id = batchRepository.AddBatch(batch);

        Console.WriteLine();
        ConsoleEx.WriteLine($"{id}", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    static void DeleteBatch()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Delete Batch", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        BatchRepository batchRepository = new();
        batchRepository.DeleteBatch(id);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Success!", ConsoleColor.Green);
        Console.ReadLine();
    }

    static void GetProducts()
    {
        Console.Clear();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Get products by Pharmacy", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        ProductRepository productRepository = new();
        var products = productRepository.GetProductsByPharmacy(id);

        foreach(var product in products)
        {
            Console.WriteLine(product);
        }
    }
}