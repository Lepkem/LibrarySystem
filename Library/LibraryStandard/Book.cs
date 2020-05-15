namespace LibraryStandard
{
    #region

    using System;

    using LibraryStandard.Interfaces;

    using Newtonsoft.Json;

    #endregion

    public class Book: IBook
    {
        
        /// <summary>
        /// The constructor for Book instances
        /// </summary>
        public Book()
        {
            ID = $"BID{Guid.NewGuid()}";
            IsAvailable = true;
            //ISBN = GenerateISBN();
            
        }


        [JsonProperty("author")]
        public string AuthorName ;                   //from JSON
        [JsonProperty("country")]
        public string Country ;                      //from JSON
        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }     //from JSON
        [JsonProperty("language")]
        public string Language ;                     //from JSON
        [JsonProperty("link")]
        public string Link { get; set; }          //from JSON
        [JsonProperty("pages")]
        public uint Pages ;                          //from JSON
        [JsonProperty("title")]
        public string Title ;                        //from JSON

        [JsonProperty("year")]
        public int Year;                           //from JSON

        public string ISBN;                   //NEEDS TO BE ADDED TO JSON

        public string ID; //NEEDS TO BE ADDED TO JSON

        public bool IsAvailable { get; set; }     //NEEDS TO BE ADDED TO JSON

        

        /// <summary>
        /// 
        /// </summary>
        public void GenerateISBN()
        {
            ISBN = $"ISBN{customHashEnc()}";
        }

        /// <summary>
        /// 
        /// </summary>
        private string base64HashEnc()
        {
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes((AuthorName.ToLower().Replace(' ', '_') + Title.ToLower().Replace(' ', '_') + Year));
            return System.Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string customHashEnc()
        {

            var x =  (AuthorName.ToLower().Replace(' ', '_') + Title.ToLower().Replace(' ', '_') + Year).GetHashCode();
            if (x < 0)
            {
                return (x *= -1).ToString();
            }
            return x.ToString();
        }

        /// <summary>
        /// ChangeImage searches through Books and changes image of the books with given imageurl
        /// </summary>
        public bool ChangeImage(string imageurl)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// ShowBookProp shows various properties of the instance of your book
        /// </summary>
        public void ShowBookProp()
        {
            Console.WriteLine($"\n*********** {this.GetType().ToString()} details **********");
            Console.WriteLine($"The title:              {Title}");
            Console.WriteLine($"The Name of the Author: {AuthorName}");
            Console.WriteLine($"The release year:       {Year}");
            Console.WriteLine($"The amount of pages:    {Pages}");
            Console.WriteLine($"The image link:         {ImageLink}");
            Console.WriteLine($"The link:               {Link.Trim()}");
            Console.WriteLine($"The ISBN number:        {ISBN}");
            Console.WriteLine($"The ID of the book:     {ID}\n");

        }

        /// <summary>
        /// ChangeLink searches through Books and changes Link of the books with a given link
        /// </summary>
        public bool ChangeLink(string link)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="book"></param>
        public void SetAvailability(bool available)
        {
            IsAvailable = available;
        }

        public bool ValidateBook()
        {
            if (String.IsNullOrWhiteSpace(Title) | String.IsNullOrWhiteSpace(AuthorName) | String.IsNullOrWhiteSpace(ID))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}   