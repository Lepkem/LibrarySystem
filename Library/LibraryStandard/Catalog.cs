using System.Collections.Generic;

namespace Library
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    using Library.Interfaces;

    using Newtonsoft.Json;

    public class Catalog : ICatalog
    {
        public Catalog()
        {
            
        }

        /// <summary>
        /// LoadBookFile loads content of filename as instances of Book
        /// </summary>
        /// <param name="fileName"></param>
        public void LoadBookFile(string fileName)
        {
            string FileContentString = "";
            try
            {
                FileContentString = System.IO.File.ReadAllText(fileName);
                Books = JsonConvert.DeserializeObject<List<Book>>(FileContentString); // here I made instances of classes from a JSON string in a list of class movie

            }
            catch (Exception e)
            { 
                Console.WriteLine($"{e.Message}, so something is not dobra :("); //
            }
        }

        public List<Book> Books { get; set; }
    }

}
