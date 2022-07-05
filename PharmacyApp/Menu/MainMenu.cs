namespace PharmacyApp.Menu;

public class MainMenu
{
    public static void Menu()
    {
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("PHARMACY APP".PadLeft(70), ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '-'), ConsoleColor.DarkYellow);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        Console.WriteLine("MAIN MENU");
        Console.WriteLine();
        Console.WriteLine(" >> AddProduct     [ap]");
        Console.WriteLine(" >> DeleteProduct  [dp]");
        Console.WriteLine(" >> AddPharmacy    [aph]");
        Console.WriteLine(" >> DeletePharmacy [dph]");
        Console.WriteLine(" >> AddStore       [as]");
        Console.WriteLine(" >> DeleteStore    [ds]");
        Console.WriteLine(" >> AddBatch       [ab]");
        Console.WriteLine(" >> DeleteBatch    [db]");
        Console.WriteLine(" >> GetProducts    [get]");
        Console.WriteLine(" >> Help           [h]");
        Console.WriteLine(" >> Exit           [e]");
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
    }

    public static void MenuS()
    {
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("PHARMACY APP".PadLeft(70), ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '-'), ConsoleColor.DarkYellow);
    }
}
