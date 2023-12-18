using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Address
    {
        /// <summary>
        /// Instance Variables:
        /// </summary>
        private string street;
        private string city;
        private string postCode;
        private Countries country;

        ///the constroctors are called when a new object is created with the keyword new. 
        /// <summary>
        /// default Constroctor that inicialationg the instance variables to empty. 
        /// </summary>
        public Address() 
        {
            street = string.Empty;
            city = string.Empty;
            postCode = string.Empty;
        }

        /// <summary>
        /// Properties get and set for street
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// Poperty, get and set the city name. 
        /// checking if the city is not en empty string becaus city is a mandatory feild. 
        /// </summary>
        public string City
        {
            get { return city; }
            set
            {
                //ckecking the 
                if (!string.IsNullOrEmpty(value))//checking that the city string is not empty.
                {
                    city = value;
                }
            }
        }

        /// <summary>
        /// Property to get and set post code
        /// </summary>
        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        /// <summary>
        /// Property to set and get the counteries. 
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; } 
        }

        /// <summary>
        /// Validate the city. Making sure that the city is not empty or null when creating a new participant. 
        /// </summary>
        /// <returns></returns>
        public bool validateCity()
        {
            bool ok = !string.IsNullOrEmpty(city);
            return ok;
        }

        /// <summary>
        /// creating a method that over riding To.string because we like to use the method to string in this way. 
        /// the countery from the enum is convereted to strinf and the whole addesss is creating to one string to be displayed later. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string selectedContery = country.ToString();
            string address = string.Format("{0, -25} {1, -8} {2, -10} {3}", street, city, postCode, selectedContery);
            return address;
        }
    }
}
