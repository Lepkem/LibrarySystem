using System;

namespace Library
{
    using Library.Interfaces;

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
            StreetName = "unknown";
            ZipCode = "unknown";
            City = "unknown";
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
            StreetName = "unknown";
            ZipCode = "unknown";
            City = "unknown";
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
            StreetName = streetName;
            ZipCode = zipcode;
            City = city;
            EmailAddress = emailAddress;
            TelephoneNumber = telephoneNumber;
        }

        protected string ID { get; }
        protected string Firstname { get; set; }
        protected string Surname { get; set; }
        protected Gend Gender { get; set; }

        public enum Gend
        {
            Male,
            Female,
            Unknown
        }

        protected string StreetName { get; set; }
        protected string ZipCode { get; set; }
        protected string City { get; set; }
        protected string EmailAddress { get; set; }
        protected string TelephoneNumber { get; set; }
        private readonly FunctionalRole _role;

        public enum FunctionalRole
        {
            Librarian,
            Customer,
            Author
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsRole(FunctionalRole role)
        {
            return _role == role;
        }

        //_MakeUsername returns new username based on first+last name
        private string _MakeUsername(string firstname, string surname)
        {
            return $"{firstname[0]}{surname}";
        }

        //_MakePassword returns a new temp password
        private string _MakePassword()
        {
            return $"Temp{Guid.NewGuid()}";
        }

        // ShowCredentials this is public for the simplicity of the project
        public string ShowCredentials(Person person)
        {
            var a = _role;
            return $"This account is a {a}";
        }

        //ShowEmail shows email of person
        public string ShowEmail(Person person)
        {
            return person.EmailAddress;
        }

        //ShowAddress shows address of person
        public string ShowAddress(Person person)
        {
            return $"{person.StreetName}, {person.ZipCode}, {person.City}";
        }

        //ShowTelNumber shows telephone number of person
        public string ShowTelNumber(Person person)
        {
            object Whateverr = CatalogV2.Test();
            return person.TelephoneNumber;
        }

    }
}