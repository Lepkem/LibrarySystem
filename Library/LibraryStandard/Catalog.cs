using System.Collections.Generic;

namespace Library
{
    using System.Reflection.Metadata.Ecma335;

    using Library.Interfaces;

    public class Catalog : ICatalog
    {
        public Catalog()
        {
            
        }

        public void LoadBookFile(string fileName)
        {
            string FileContentString = "";
            try
            {
                FileContentString = System.IO.File.ReadAllText(fileName);
                DeserializedS = JsonConvert.DeserializeObject<List<Book>>(FileContentString); // here I made instances of classes from a JSON string in a list of class movie

            }
            catch (Exception e)
            {
                return e.Message + "something went wrong";
            }
        }
    }

}
