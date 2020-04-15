using System.Collections.Generic;

namespace Library
{
    using System.Reflection.Metadata.Ecma335;

    public sealed class Catalog
    {
        static int Catalogcounter=0;
        private Catalog()
        {
            Catalogcounter++;
        }

        private static readonly Catalog _instance = new Catalog();
        public static Catalog Instance
        { get { return _instance; } }

        public List<Book> AllBooks;
        public List<BookItem> AllBookItems;

    }


    public static class CatalogV2
    {
        public static object Test()
        {
            return new object();
        }
    }
}
