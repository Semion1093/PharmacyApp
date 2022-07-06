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
            Console.WriteLine(" >> Add Product     - enter [Add Product]       or [ap]   to add a product to database ");
            Console.WriteLine(" >> Delete Product  - enter [Delete Product]    or [em]   to delete a product from database");
            Console.WriteLine(" >> Add Fharmacy    - enter [Add Fharmacy]      or [aph]  to add a pharmacy to database");
            Console.WriteLine(" >> Delete Fharmacy - enter [Delete Fharmacy]   or [dph]  to delete a product from database");
            Console.WriteLine(" >> Add Store       - enter [Add Store]         or [as]   to add a store to database");
            Console.WriteLine(" >> Delete Store    - enter [Delete Store]      or [ds]   to delete a store from database");
            Console.WriteLine(" >> Add Batch       - enter [Add Batch]         or [ab]   to add a batch to database");
            Console.WriteLine(" >> Delete Batch    - enter [Delete Batch]      or [db]   to delete a batch from database");
            Console.WriteLine(" >> Get Products    - enter [Get Products]      or [get]  to get products in pharmacy");
            Console.WriteLine(" >> Exit            - enter [Exit]              or [e]    to exit from the application");
            Console.WriteLine();
            ConsoleEx.WriteLine("".PadLeft(115, '='), ConsoleColor.DarkMagenta);
            Console.Write(" Press ENTER to continue... ");
            Console.ReadLine();
        }
    }
}
