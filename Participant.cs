using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Participant
    {
        private Address address = new Address();
        private string firstName;
        private string lastName;

        ///
        
        /// 
        
        public Participant ()
        {
            firstName = string.Empty;
            lastName = string.Empty;
        }
        public Participant(string firstName, string lastName, Address address) :this()
        {
            Address = address;
            FirstName = firstName;
            LastName = lastName;
            
        }




        /// <summary>
        /// property    get and set address.
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        /// <summary>
        /// Property to get and set first name
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        /// <summary>
        /// Property to get and set first name
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        /// <summary>
        /// Propity to get full name: 
        /// </summary>
        public string Fullname
        {
            get
            {
                return firstName + lastName;
            }
        }

        public bool validateName(string name)
        {
            bool ok = !string.IsNullOrEmpty(name);
            return ok;
        }

        public string fullParticapantToString()
        {
            validateName(this.firstName);
            validateName(this.lastName);
            string addressOfPerson;
            addressOfPerson = address.addressToString();
            string name;
            name = lastName.ToUpper() + ", " + firstName + addressOfPerson;

            return name;
           
        }
    }
}
   

