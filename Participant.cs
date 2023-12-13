using System;
using System.Collections.Generic;
using System.Linq;
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

        public string fullNameToString()
        {
            validateName(this.firstName);
            validateName(this.lastName);
            string name;
            name = lastName.ToUpper() + ", " + firstName;
            return name;
        }
    }
}
   

