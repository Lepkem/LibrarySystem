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
            _book.Link = link;
            return this;
        }
        public BookBuilder WithImageLink(string imglink)
        {
            _book.ImageLink = imglink;
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
        public BookBuilder WithPages(string pages)
        {
            uint parsedPages = 1996;
            uint.TryParse(pages, out parsedPages);

            _book.Pages = parsedPages;
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
        public BookBuilder WithYear(string year)
        {
            int parsedYear = 1996;
            Int32.TryParse(year, out parsedYear);

            _book.Year = parsedYear;
            return this;
        }


        /// <summary>
        /// Create validates book, then generates isbn and returns the book
        /// </summary>
        /// <returns></returns>
        public Book Create()
        {
            if (_book.ValidateBook())
            {
                _book.GenerateISBN();
                return _book;
            }
            else
            {
                Console.WriteLine($"The book has no title or name of the author.");
                StandardMessages.TryAgain();
                return null;
            }
        }

        
    }

}