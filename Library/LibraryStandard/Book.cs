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
           //ISBN = GenerateISBN();
            
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
        private bool ChangeImage(string imageurl)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ShowBookProp shows various properties of the instance of your book
        /// </summary>
        public void ShowBookProp()
        {

            Console.WriteLine($"The title:");
            Console.WriteLine($"{Title}");
            Console.WriteLine($"The name of the author:");
            Console.WriteLine($"{AuthorName}");
            Console.WriteLine($"The release year:");
            Console.WriteLine($"{Year}");
            Console.WriteLine($"The amount of pages:");
            Console.WriteLine($"{Pages}");
            Console.WriteLine($"The image link:");
            Console.WriteLine($"{ImageLink}");
            Console.WriteLine($"The link:");
            Console.WriteLine($"{Link}");
            Console.WriteLine($"The ISBN number:");
            Console.WriteLine($"{ISBN}");
            Console.WriteLine($"The ID of the book:");
            Console.WriteLine($"{ID}");
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