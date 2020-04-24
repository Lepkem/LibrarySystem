using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStandard.Person
{
    using Library;

    class Customer : Person
    {
        public Customer(string firstname, string surname, FunctionalRole role)
            : base(firstname, surname, role)
        {
        }

        public Customer(string firstname, string surname, FunctionalRole role, string username, string password)
            : base(firstname, surname, role, username, password)
        {
        }

        public Customer(string firstname, string surname, Gend gender = Gend.Unknown, string streetName = "unknown", string zipcode = "unknown", string city = "unknown", string emailAddress = "unknown", string telephoneNumber = "unknown", FunctionalRole role = FunctionalRole.Customer)
            : base(firstname, surname, gender, streetName, zipcode, city, emailAddress, telephoneNumber, role)
        {
        }
    }
}
