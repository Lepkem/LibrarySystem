namespace Library
{
    #region

    using System;

    using Library.Interfaces;

    #endregion

    public class Book : IBook
    {
        /// 1# elaborate constructor
        public Book(Person author, string title, string country, string imageLink, string language, string link, uint pages, DateTime year)
        {
            Author = author;
            Country = country;
            ImageLink = imageLink;
            Language = language;
            Link = link;
            Pages = pages;
            Title = title;
            Year = year;

            ISBN = "ISBN" + Guid.NewGuid();
            IsAvailable = true;
            AvailableWhen = DateTime.Now;
        }

        /// 2# elaborate constructor
        public Book(Person author, string title, string country, string language, uint pages, DateTime year)
        {
            Author = author;
            Country = country;
            ImageLink = "unknown";
            Language = language;
            Link = "unknown";
            Pages = pages;
            Title = title;
            Year = year;

            ISBN = "ISBN" + Guid.NewGuid();
            IsAvailable = true;
            AvailableWhen = DateTime.Now;
        }

        /// 3# elaborate constructor 
        public Book(Person author, string title)
        {
            Author = author;
            Title = title;
            Country = "unknown";
            ImageLink = "unknown";
            Language = "unknown";
            Link = "unknown";
            Pages = 0;
            Year = DateTime.Now;

            ISBN = "ISBN" + Guid.NewGuid();
            IsAvailable = true;
            AvailableWhen = DateTime.Now;
        }

        /// 4# elaborate constructor 
        public Book()
        {
            Author = new Person("unknown", "unknown", Person.FunctionalRole.Author);
            Title = "unknown";
            Country = "unknown";
            ImageLink = "unknown";
            Language = "unknown";
            Link = "unknown";
            Pages = 0;
            Year = DateTime.Now;

            ISBN = "ISBN" + Guid.NewGuid();
            IsAvailable = true;
            AvailableWhen = DateTime.Now;
        }



        public readonly Person Author;

        public readonly string Country; //from JSON

        public string ImageLink { get; protected set; } //from JSON

        public readonly string Language; //from JSON

        public string Link { get; protected set; } //from JSON

        public readonly uint Pages; //from JSON

        public readonly string Title; //from JSON

        public readonly DateTime Year; //from JSON

        public readonly string ISBN;

        public bool IsAvailable { get; protected set; }

        public DateTime AvailableWhen { get; protected set; }

        /// <summary>
        /// ChangeImage searches through Books and changes image of the books with given ISBN
        /// </summary>
        private bool ChangeImage(string ISBN)
        {
            
            throw new NotImplementedException();
        }

        /// <summary>
        /// ChangeLink searches through Books and changes Link of the books with given ISBN
        /// </summary>
        private bool ChangeLink(string ISBN)
        {
            throw new NotImplementedException();
        }
    }
}