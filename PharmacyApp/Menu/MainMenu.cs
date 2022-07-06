namespace PharmacyApp.Menu;

public class MainMenu
{
    public static void Menu()
    {
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("PHARMACY APP".PadLeft(70), ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '-'), ConsoleColor.DarkYellow);
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        Console.WriteLine("MAIN MENU".PadLeft(15));
        Console.WriteLine();
        Console.WriteLine(" >> Add Product     [ap]");
        Console.WriteLine(" >> Delete Product  [dp]");
        Console.WriteLine(" >> Add Pharmacy    [aph]");
        Console.WriteLine(" >> Delete Pharmacy [dph]");
        Console.WriteLine(" >> Add Store       [as]");
        Console.WriteLine(" >> Delete Store    [ds]");
        Console.WriteLine(" >> Add Batch       [ab]");
        Console.WriteLine(" >> Delete Batch    [db]");
        Console.WriteLine(" >> Get Products    [get]");
        Console.WriteLine(" >> Help            [h]");
        Console.WriteLine(" >> Exit            [e]");
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
    }

    public static void MenuS()
    {
        ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
        ConsoleEx.WriteLine("PHARMACY APP".PadLeft(70), ConsoleColor.Gray);
        ConsoleEx.WriteLine("".PadLeft(115, '-'), ConsoleColor.DarkYellow);
    }
}
