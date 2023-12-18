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
        //instance variables
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
        /// property get and set address.
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        /// <summary>
        /// Property to get and set firstname
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Property to get and set lastname
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        /// <summary>
        /// validation of both names and the address. the address validation is calling the method in the address class and name validation happens here. this method is to be called in an other class. 
        /// </summary>
        /// <returns></returns>
        public bool validateParticipant()
        {
            bool addressok = address.validateCity();//is address okay and can it be used?
            bool ok = (!string.IsNullOrEmpty(firstName)) && (!string.IsNullOrEmpty(lastName)); //is the name not empty or null
            return addressok && ok;//returning if this valus are ok. 
        }

        /// <summary>
        /// overriding method to creat the participant string that will be displayed in the listbox in th UI
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string addressOfPerson = address.ToString();//saving address in string
            string name = string.Format("{0, -20} {1, -20} {2}", lastName.ToUpper(),  firstName, addressOfPerson);// creating the string to be displayed

            return name;//returning the name
           
        }
    }
}
   

