namespace PharmacyApp.Menu
{
    public class HelpMenu
    {
        public static void Help()
        {
            Console.Clear();
            ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
            ConsoleEx.WriteLine("PHARMACY APP".PadLeft(70), ConsoleColor.Gray);
            ConsoleEx.WriteLine("".PadLeft(115, '-'), ConsoleColor.DarkYellow);
            ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
            Console.WriteLine("HELP");
            Console.WriteLine();
            Console.WriteLine(" Available commands: ");
            Console.WriteLine();
            Console.WriteLine(" >> Add Medicine     - enter [AddMedicine]    or [am]    to add a medicine to database ");
            Console.WriteLine(" >> Edit Medicine    - enter [EditMedicine]   or [em]    to edit data of a medicine");
            Console.WriteLine(" >> Update Amount    - enter [UpdateAmount]   or [ua]    to update an amount of selected medicine");
            Console.WriteLine(" >> Delete Medicine  - enter [DeleteMedicine] or [dm]    to delete a medicine from database");
            Console.WriteLine(" >> Show Medicines   - enter [ShowMedicines]  or [sm]    to show list of medicines from database");
            Console.WriteLine(" >> Sell Medicine    - enter [SellMedicine]   or [sell]  to sell a medicine");
            Console.WriteLine(" >> Exit             - enter [Exit]           or [e]     to exit from the application");
            Console.WriteLine();
            ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
            Console.Write(" Press ENTER to continue... ");
            Console.ReadLine();
        }
    }
}
