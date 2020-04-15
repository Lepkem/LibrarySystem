using System;
using System.Collections.Generic;
using System.Text;


namespace Library
{
    interface ICatalog
    {

        
        // LoadBookFile() {}
        string SearchBook(Book book /* or any key or attribute from book*/);
        //this method should return a string with the attributes of the book,
        //the amount of bookitems and the available bookitems of the book
        // Y3VzdG9tIGtsYXNhIHogcmVzdWx0ZW0gc2VhcmNoZSdhCg==

        bool BookItemAvailable(BookItem bookItem);

        bool AddBookItem(Book book); // this influences LendedItemsDict, BookItemsLis
    }
}
