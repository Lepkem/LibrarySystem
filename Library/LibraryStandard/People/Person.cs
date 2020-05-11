namespace LibraryStandard.People
{
    using LibraryStandard.Interfaces;

    public class Person : IPerson
    {
        public string ID; 


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

        public Address Address { get; private set; }
        protected string ID { get; }
        protected string Firstname { get; set; }
        protected string Surname { get; set; }
        protected Gend Gender { get; set; }

        public enum Gend
        {
            Unknown,
            Male,
            Female
            
        }

        protected string EmailAddress { get; set; }
        protected string TelephoneNumber { get; set; }
        protected readonly FunctionalRole _role;

        public enum FunctionalRole
        {
            Customer,
            Librarian,
            Author
        }

        public string Username { get; set; }
        public string Password { get; set; }

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
    }
*/
}