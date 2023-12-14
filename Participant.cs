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
        private Address address;
        private string firstName;
        private string lastName;

        /// <summary>
        /// default constructor. In this default constructor a new object of the address class is created. 
        /// </summary>
        public Participant ()
        {
            address = new Address();//creating an object of the address. 
            firstName = string.Empty;
            lastName = string.Empty;
        }
        /// <summary>
        /// Constructor with parameters of firstName abd lastName and Address. 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        public Participant(string firstName, string lastName, Address address) :this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
            if (address != null) // if address is not null then add the address
            {
                this.address = address;
            }
            else
            {
                address = new Address();// if address is null the create a new object of the address. 
            }
        }

        ///copy constructor.


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
            //validate all in pits. address could (but I do it in its on class) be calidated by calling its validation method. 
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
            name = string.Format("{0, -20} {1, -20} {2}", lastName.ToUpper() + ", " + firstName + addressOfPerson);

            return name;
           
        }
    }
}
   

