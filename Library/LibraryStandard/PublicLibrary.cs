namespace Library
{
    using Library.Interfaces;

    public class PublicLibrary : IPublicLibrary
    {

        public Catalog Catalog { get; private set; }

        public PublicLibrary()
        {
            Catalog = new Catalog();
        }
    }
}