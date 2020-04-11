using System;

namespace Library
{
    public class Person
    {
        // var author = new Person() 
        // var aut = new Person("a","sss") 
        

        // enum - author - librarian - customer 
        // property of th above type within the person class 
        // not modifiable - set up once during creation 
        // not visible outside of the class 

        public Person(string firstname, string surname, PersonKind status, string username, string password)
        {
            this.ID = "PID" + Guid.NewGuid();
            this.Status = status;
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
            string telephoneNumber= "unknown", PersonKind status = PersonKind.Customer
        )
        {
            this.ID = "PID" + Guid.NewGuid();
            this.Firstname = firstname;
            this.Surname = surname;
            this.Status = status;
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
        protected string EmailAddress { get; set; }
        protected string TelephoneNumber { get; set; }
        protected PersonKind Status { get; }
        public enum PersonKind
        {
            Librarian,
            Customer,
            Author
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}