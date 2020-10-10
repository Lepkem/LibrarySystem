namespace LibraryStandard
{
    using System;

    using LibraryStandard.People;

    public class PersonBuilder
    {
        private Person _person;

        public PersonBuilder()
        {
           _person = new Person();
        }

        /// <summary>
        /// ValidatePerson private returns a bool
        /// </summary>
        /// <returns></returns>
        private bool ValidatePerson()
        {
            if (String.IsNullOrWhiteSpace(_person.Password) || String.IsNullOrWhiteSpace(_person.ID) || String.IsNullOrWhiteSpace(_person.Firstname)
                | String.IsNullOrWhiteSpace(_person.Surname))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public PersonBuilder WithFirstName(string firstname)
        {
            _person.Firstname = firstname;
            return this;
        }

        public PersonBuilder WithLastName(string lastname)
        {
            _person.Surname = lastname;
            return this;
        }

        public PersonBuilder WithGender(Person.Gend gender)
        {
            _person.Gender = gender;
            return this;
        }

        public PersonBuilder WithEmailAddress(string emailAddress)
        {
            _person.EmailAddress = emailAddress;
            return this;
        }

        public PersonBuilder WithPassword(string password)
        {
            _person.Password = password;
            return this;
        }

        public PersonBuilder WithStreetnumberAdd(string streetnumberAdd)
        {
            _person.StreetnumberAdd = streetnumberAdd;
            return this;
        }

        public PersonBuilder WithStreetnumber(string Streetnumber)
        {
            _person.Streetnumber = Streetnumber;
            return this;
        }

        public PersonBuilder WithStreetName(string streetName)
        {
            _person.StreetName = streetName;
            return this;
        }

        public PersonBuilder WithZipCode(string zipCode)
        {
            _person.ZipCode = zipCode;
            return this;
        }

        public PersonBuilder WithCity(string city)
        {
            _person.City = city;
            return this;
        }

        public PersonBuilder WithNationality(string nationality)
        {
            _person.Nationality = nationality;
            return this;
        }

        public PersonBuilder WithTelePhoneNumber(string telephoneNumber)
        {
            _person.TelephoneNumber = telephoneNumber;
            return this;
        }

        /// <summary>
        /// generates a username
        /// </summary>
        private void UserNameGenerator()
        {
            _person.Username = $"{_person.Firstname[1]}{_person.Surname}{_person.ID[0]}{_person.ID[1]}{_person.ID[2]}{_person.ID[3]}";
        }

        /// <summary>
        /// Create returns a person with username if validation was succesful, else null
        /// </summary>
        /// <returns></returns>
        public Person Create()
        {
            

            if (ValidatePerson())
            {
                UserNameGenerator();
                return _person;
            }
            else
            {
                return null;
            }
        }




    }
}