namespace LibraryStandard.People
{
    using System;
    
    using LibraryStandard.Interfaces;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class Person 
    {
        public Person()
        {
            ID = "PID" + Guid.NewGuid();
        }
        //todo implement csv file
        //Number,Gender, nationality ,GivenName,Surname,StreetAddress,ZipCode,City,EmailAddress,Username,TelephoneNumber
        [JsonProperty("Number")]
        public string ID { get; }
        //public Address Address { get; set; }
        [JsonProperty("GivenName")]
        public string Firstname { get; set; }
        public string Surname { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Gend Gender { get; set; }
        
        //public string Gender { get; set; }
        public string Nationality { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string StreetnumberAdd { get; set; }
        public string Streetnumber { get; set; }
        [JsonProperty("StreetAddress")]
        public string StreetName { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public enum Gend
        {
            Unknown,
            Male,
            Female
        }

        public bool ValidatePerson()
        {
            if (String.IsNullOrWhiteSpace(Username) | String.IsNullOrWhiteSpace(Password) | String.IsNullOrWhiteSpace(ID) | String.IsNullOrWhiteSpace(Firstname)
                | String.IsNullOrWhiteSpace(Surname))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowPersonProps()
        {
            Console.WriteLine($"\n*********** {this.GetType().ToString()} details **********");
            Console.WriteLine($"First name:             {Firstname}");
            Console.WriteLine($"Last name:              {Surname}");
            Console.WriteLine($"Person ID:              {ID}");
            Console.WriteLine($"Username:               {Username}");
            Console.WriteLine($"Nationality:            {Nationality}");
            Console.WriteLine($"Password:               {PasswordCensor()}");
            Console.WriteLine($"\nGender:               {Gender}");
            Console.WriteLine($"Email Address           {EmailAddress}");
            Console.WriteLine($"Telephone number:       {TelephoneNumber}");
            Console.WriteLine($"House number:          {Streetnumber}");
            Console.WriteLine($"House number addition: {StreetnumberAdd}");
            Console.WriteLine($"Street name:            {StreetName}");
            Console.WriteLine($"Zip code:               {ZipCode}");
            Console.WriteLine($"City:                   {City}");
        }

        private string PasswordCensor()
        {
            if (!string.IsNullOrEmpty(Password))
            {
                string sensoredPassword = "";
                foreach (char letter in Password)
                {
                    sensoredPassword += "*";
                }

                return sensoredPassword;
            }

            return "***";

        }

    }

    /*
    public class Person : IPerson
    {
        // property of th above type within the person class 
        // not modifiable - set up once during creation 
        // not visible outside of the class 
        public Person(string firstname, string surname, FunctionalRole role)
        {
            ID = "PID" + Guid.NewGuid();
            _role = role;
            Firstname = firstname;
            Surname = surname;
            Username = _MakeUsername(firstname, surname);
            Password = _MakePassword();
            Gender = Gend.Unknown;
            
            EmailAddress = "unknown";
            TelephoneNumber = "unknown";
        }

        public Person(string firstname, string surname, FunctionalRole role, string username, string password)
        {
            ID = "PID" + Guid.NewGuid();
            _role = role;
            Firstname = firstname;
            Surname = surname;
            Username = username;
            Password = password;
            Gender = Gend.Unknown;
            EmailAddress = "unknown";
            TelephoneNumber = "unknown";
        }

        public Person(string firstname, string surname, Gend gender = Gend.Unknown, string streetName = "unknown",
            string zipcode = "unknown", string city = "unknown", string emailAddress = "unknown",
            string telephoneNumber = "unknown", FunctionalRole role = FunctionalRole.Customer)
        {
            ID = "PID" + Guid.NewGuid();
            Firstname = firstname;
            Surname = surname;
            _role = role;
            Gender = gender;
            EmailAddress = emailAddress;
            TelephoneNumber = telephoneNumber;
        }
        
        protected readonly FunctionalRole _role;

        public enum FunctionalRole
        {
            Customer,
            Librarian,
            Author
        }

    

        /// <summary>
        /// returns bool if instance role is param role
        /// </summary>
        /// <returns>bool</returns>
        public bool IsRole(FunctionalRole role)
        {
            return _role == role;
        }

        /// <summary>
        /// _MakeUsername returns new username based on first+last name
        /// </summary>
        /// <returns>string</returns>
        virtual protected string _MakeUsername(string firstname, string surname)
        {
            return $"{firstname[0]}{surname}";
        }

        /// <summary>
        /// _MakePassword returns a new temp password
        /// </summary>
        /// <returns>string</returns>
        protected string _MakePassword()
        {
            return $"Temp{Guid.NewGuid()}";
        }

        /// <summary>
        /// // ShowCredentials this is public for the simplicity of the project
        /// </summary>
        /// <returns>string</returns>
        public string ShowCredentials(Person person)
        {
            var a = _role;
            return $"This account is a {a}";
        }

        /// <summary>
        /// //ShowEmail shows email of person
        /// </summary>
        /// <returns>string</returns>
        public string ShowEmail(Person person)
        {
            return person.EmailAddress;
        }

        /// <summary>
        /// ShowAddress shows address of person
        /// </summary>
        /// <returns>string</returns>

        public string ShowAddress(Person person)
        {
            //return $"{person.StreetName}, {person.ZipCode}, {person.City}";
            return "";
        }


        /// <summary>
        /// ShowTelNumber shows telephone number of person
        /// </summary>
        /// <returns>string</returns>
        public string ShowTelNumber(Person person)
        {
            return person.TelephoneNumber;
        }

        /// <summary>
        /// fullname of the person
        /// </summary>
        /// <returns>string</returns>
        public string ShowFullName()
        {
            return $"{this.Firstname} {this.Surname}";
        }
        public string GetCredentials(Person person)
        {
            throw new System.NotImplementedException();
        }

        public string GetEmail(Person person)
        {
            throw new System.NotImplementedException();
        }

        public string GetAddress(Person person)
        {
            throw new System.NotImplementedException();
        }

        public string GetTelNumber(Person person)
        {
            throw new System.NotImplementedException();
        }

        public string GetFullName()
        {
            throw new System.NotImplementedException();
        }
    }
*/

}