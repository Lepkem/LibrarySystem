namespace Library
{
    using Library.Interfaces;

    public class PublicLibrary : IPublicLibrary
    {

        public readonly Catalog Catalog;

        public PublicLibrary()
        {
            Catalog = new Catalog();
        }


    }
}