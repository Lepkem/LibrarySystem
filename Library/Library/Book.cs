using System;
using Microsoft.VisualBasic;

namespace Library
{
    public class Book
    {
        // Person 
        public Book(Person author, string country = "unknown", string imageLink = "unknown",
            string language = "unknown", string link = "unknown", uint pages = 0,
            string title = "unknown", DateTime year = DateTime.Now)
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