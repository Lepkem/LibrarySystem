namespace Library.Interfaces
{
    using System;

    public interface IBook
    {
        Person Author { get; }
        string Country { get; } //from JSON
        string ImageLink { get; } //from JSON
        string Language { get; } //from JSON
        string Link { get; } //from JSON
        uint Pages { get; } //from JSON
        string Title { get; } //from JSON
        DateTime Year { get; } //from JSON
        string ISBN { get; }
        
    }
}