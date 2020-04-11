using System;
using Microsoft.VisualBasic;

namespace Library
{
    public class Book
    {
        public Book(Person author, string country = "unknown", string imageLink = "unknown",
            string language = "unknown", string link = "unknown", uint pages = 0,
            string title = "unknown", DateTime year = DateTime.Now)
        {
            this.Author = author;
            this.Country = country;
            this.ImageLink = imageLink;
            this.Language = language;
            this.Link = link;
            this.Pages = pages;
            this.Title = title;
            this.Year = year;
            this.ISBN = "ISBN" + Guid.NewGuid();
        }

        public Person Author { get; }
        public string Country { get;}      //from JSON
        public string ImageLink { get; protected set; }    //from JSON
        public string Language { get;}     //from JSON
        public string Link { get; protected set;}         //from JSON
        public uint Pages { get;}          //from JSON
        public string Title { get;}        //from JSON
        public DateTime Year { get;}       //from JSON
        public string ISBN { get;}
        public uint BookQuantity;   //this one should be created by counting the BookItems of this book


    }
}