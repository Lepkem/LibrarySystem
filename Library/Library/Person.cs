using System;

namespace Library
{
    public class Person
    {
        // var Jska = new Person(librarian) 
        // var Raf = new Person("a","sss",Customer) 

        private void LibrarianMethod()
        {

        }

        private void CustomerMethod()
        {

        }



        // enum - author - librarian - customer 
        // property of th above type within the person class 
        // not modifiable - set up once during creation 
        // not visible outside of the class 
        public Person(string firstname, string surname, FunctionalRole role)
        {
            this.ID = "PID" + Guid.NewGuid();
            this._role = role;
            this.Firstname = firstname;
            this.Surname = surname;
            this.Username = $"{surname}{firstname}";
            this.Password = $"{Guid.NewGuid()}";
            this.Gender = Gend.Unknown;
            this.StreetName = "unknown";
            this.ZipCode = "unknown";
            this.City = "unknown";
            this.EmailAddress = "unknown";
            this.TelephoneNumber = "unknown";
        }

        public Person(string firstname, string surname, FunctionalRole role, string username, string password)
        {
            this.ID = "PID" + Guid.NewGuid();
            this._role = role;
            this.Firstname = firstname;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.Gender = Gend.Unknown;
            this.StreetName = "unknown";
            this.ZipCode = "unknown";
            this.City = "unknown";
            this.EmailAddress = "unknown";
            this.TelephoneNumber = "unknown";

        }
        public Person(string firstname, string surname, Gend gender =Gend.Unknown, string streetName="unknown", 
            string zipcode= "unknown", string city= "unknown", string emailAddress = "unknown",
            string telephoneNumber= "unknown", FunctionalRole role = FunctionalRole.Customer
        )
        {
            this.ID = "PID" + Guid.NewGuid();
            this.Firstname = firstname;
            this.Surname = surname;
            this._role = role;
            this.Gender = gender;
            this.StreetName = streetName;
            this.ZipCode = zipcode;
            this.City = city;
            this.EmailAddress = emailAddress;
            this.TelephoneNumber = telephoneNumber;
            

        }
        protected string ID { get;}
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
        public bool IsLibrarian = (_role == FunctionalRole.Librarian);
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
    }
}