using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStandard
{
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
