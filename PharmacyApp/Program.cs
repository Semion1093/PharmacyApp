using PharmacyApp.Menu;
using PharmacyApp.Models;
using PharmacyApp.Repositories;

bool exitApp = false;
var productRepository = new ProductRepository();
var pharmacyRepository = new PharmacyRepository(); 
var storeRepository = new StoreRepository();
var batchRepository = new BatchRepository();

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
        case "Add Product":
        case "ap":
            AddProduct();
            break;
        case "Delete Product":
        case "dp":
            DeleteProduct();
            break;
        case "Add Pharmacy":
        case "aph":
            AddPharmacy();
            break;
        case "Delete Pharmacy":
        case "dph":
            DeletePharmacy();
            break;
        case "Add Store":
        case "as":
            AddStore();
            break;
        case "Delete Store":
        case "ds":
            DeleteStore();
            break;
        case "Add Batch":
        case "ab":
            AddBatch();
            break;
        case "Delete Batch":
        case "db":
            DeleteBatch();
            break;
        case "Get Products":
        case "get":
            GetProductsByPharmacy();
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

    void AddProduct()
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

        var id = productRepository.AddProduct(product);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Product Id = {id}", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    void DeleteProduct()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Delete Product", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        productRepository.DeleteProduct(id);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Success!", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    void AddPharmacy()
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

        var id = pharmacyRepository.AddPharmacy(pharmacy);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Pharmacy Id = {id}", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }
     
    void DeletePharmacy()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Delete Pharmacy", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        pharmacyRepository.DeletePharmacy(id);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Success!", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    void AddStore()
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

        var id = storeRepository.AddStore(store);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Store Id = {id}", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    void DeleteStore()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Delete Store", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        storeRepository.DeleteStore(id);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Success!", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    void AddBatch()
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

        var id = batchRepository.AddBatch(batch);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Batch Id = {id}", ConsoleColor.Green);
        Console.Write("Press ENTER to continue... ");
        Console.ReadLine();
    }

    void DeleteBatch()
    {
        Console.Clear();
        MainMenu.MenuS();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Delete Batch", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        batchRepository.DeleteBatch(id);

        Console.WriteLine();
        ConsoleEx.WriteLine($"Success!", ConsoleColor.Green);
        Console.ReadLine();
    }

    void GetProductsByPharmacy()
    {
        Console.Clear();
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("Get products by Pharmacy", ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);

        Console.Write(" >> Id: ");
        int id = Convert.ToInt32(Console.ReadLine().Trim());

        var products = productRepository.GetProductsByPharmacy(id);

        foreach(var product in products)
        {
            Console.WriteLine($" Наименование товара: {product.Name}, Количество: {product.Count}");
        }

        Console.ReadLine();
    }
}