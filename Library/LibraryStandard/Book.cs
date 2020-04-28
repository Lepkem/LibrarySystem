namespace Library
{
    #region

    using System;

    using Library.Interfaces;

    using Newtonsoft.Json;
    

    #endregion

    public class Book: IBook
    {
        
        /// <summary>
        /// The constructor for Book instances
        /// </summary>
        public Book()
        {
            ID = Guid.NewGuid().ToString();
            IsAvailable = true;
            AvailableWhen = DateTime.Now;
            ISBN = "";
        }

        [JsonProperty("author")]
        public string AuthorName;                  //from JSON
        [JsonProperty("country")]
        public string Country;                     //from JSON
        [JsonProperty("imageLink")]
        public string ImageLink { get; protected set; }     //from JSON
        [JsonProperty("language")]
        public string Language;                    //from JSON
        [JsonProperty("link")]
        public string Link { get; protected set; }          //from JSON
        [JsonProperty("pages")]
        public uint Pages;                         //from JSON
        [JsonProperty("title")]
        public string Title;                       //from JSON
        [JsonProperty("year")]
        public int Year;                           //from JSON

        public string ISBN;                        //NEEDS TO BE ADDED TO JSON

        public string ID;                          //NEEDS TO BE ADDED TO JSON

        public bool IsAvailable { get; protected set; }     //NEEDS TO BE ADDED TO JSON

        public DateTime AvailableWhen { get; protected set; } //NEEDS TO BE ADDED TO JSON




        /// <summary>
        /// ChangeImage searches through Books and changes image of the books with given imageurl
        /// </summary>
        private bool ChangeImage(string imageurl)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ShowBookProp shows various properties of the instance of your book
        /// </summary>
        public void ShowBookProp()
        {
            Console.WriteLine($"{Title}");
            Console.WriteLine($"{AuthorName}");
            Console.WriteLine($"{Year}");
            Console.WriteLine($"{Pages}");
        }

        /// <summary>
        /// ChangeLink searches through Books and changes Link of the books with a given link
        /// </summary>
        private bool ChangeLink(string link)
        {
            throw new NotImplementedException();
        }
    }
}   