using System;
using Library; 

namespace Jafiler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person Jordan = new Person("Jordan", "Guerrero", Person.FunctionalRole.Author);
            Book ourBook = new Book(Jordan, "Too much passion for anything good");
        }
    }
}
