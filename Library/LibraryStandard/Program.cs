namespace LibraryStandard
{
    using System;

    using Library;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome User");
            Console.ReadLine();
            Catalog catalog = new Catalog();
            catalog.LoadBookFile(@"Data\Books.json");
            Console.ReadLine();
        }
    }
}
