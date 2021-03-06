﻿namespace LibraryStandard.Menu
{
    using System;

    using EasyConsole;

    //menu 1=>B
    public class CatalogMenu : MenuPage
    {
        public CatalogMenu(Program program)
            : base(
                "Catalog menu",
                program,
                new Option("Search a book", () => program.NavigateTo<SearchBook>())
                ,new Option("Show all books", () => program.NavigateTo<ShowAllBooks>())
               

                )
        {
        }


    }
}
