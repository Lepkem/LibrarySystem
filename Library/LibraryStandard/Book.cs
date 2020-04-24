namespace Library
{
    #region

    using System;

    using Library.Interfaces;

    using Newtonsoft.Json;

    #endregion

    public class Book : IBook
    {
        
        /// <summary>
        /// The constructor for Book instances
        /// </summary>
        public Book()
        {
            ID = Guid.NewGuid().ToString();
            ISBN = "ISBN" + Guid.NewGuid();
            IsAvailable = true;
            AvailableWhen = DateTime.Now;
        }


        [JsonProperty("author")]
        public readonly string AuthorName;                  //from JSON
        [JsonProperty("country")]
        public readonly string Country;                     //from JSON
        [JsonProperty("imageLink")]
        public string ImageLink { get; protected set; }     //from JSON
        [JsonProperty("language")]
        public readonly string Language;                    //from JSON
        [JsonProperty("link")]
        public string Link { get; protected set; }          //from JSON
        [JsonProperty("pages")]
        public readonly uint Pages;                         //from JSON
        [JsonProperty("title")]
        public readonly string Title;                       //from JSON
        [JsonProperty("year")]
        public readonly int Year;                           //from JSON
        
        public readonly string ISBN;                        //NEEDS TO BE ADDED TO JSON

        public readonly string ID;                          //NEEDS TO BE ADDED TO JSON

        public bool IsAvailable { get; protected set; }     //NEEDS TO BE ADDED TO JSON

        public DateTime AvailableWhen { get; protected set; } //NEEDS TO BE ADDED TO JSON



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