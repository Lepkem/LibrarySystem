namespace LibraryStandard
{
    using System;
    using System.Data;

    using LibraryStandard.Helpers;

    using Newtonsoft.Json;

    public class BookBuilder
    {
        private Book _book;

        public BookBuilder()
        {
            _book = new Book();
        }


        public BookBuilder WithAuthorName(string authorname)
        {
            _book.AuthorName = authorname;
            return this;
        }

        public BookBuilder WithCountry(string country)
        {
            _book.Country = country;
            return this;
        }

        public BookBuilder WithLink(string link)
        {
            //_book.Link = link;
            return this;
        }
        public BookBuilder WithImageLink(string imglink)
        {
            //_book.ImageLink = imglink;
            return this;
        }

        public BookBuilder WithLanguage(string lang)
        {
            _book.Language = lang;
            return this;
        }

        public BookBuilder WithPages(uint pagamount)
        {
            _book.Pages = pagamount;
            return this;
        }

        public BookBuilder WithTitle(string title)
        {
            _book.Title = title;
            return this;
        }

        public BookBuilder WithYear(int year)
        {
            _book.Year = year;
            return this;
        }

        public Book CreateBook()
        {
            if (!String.IsNullOrEmpty(_book.Title) && String.IsNullOrEmpty(_book.AuthorName))
            {
                return _book;
            }
            else
            {
                Console.WriteLine($"The book has no title or name of the author.");
                StandardMessages.Instance.TryAgain();
                return new Book();
            }
        }


    }

}