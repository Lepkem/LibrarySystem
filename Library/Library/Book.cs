using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Library
{

    public class Book
    {
        // 1# elaborate constructor
        public Book(Person author, string title, string country,
            string imageLink, string language, string link, uint pages, DateTime year)
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
        }
        
        // 2# elaborate constructor
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
        }

        // 3# elaborate constructor 
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
        }

        // 3# elaborate constructor 
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
        }

        public List<Book> BookAttr = new List<Book>(); // is this a good idea? I think this will be redundant in the future
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

        public bool Whatever(uint pages)
        {
            return (pages > 0);
        }
    }
}