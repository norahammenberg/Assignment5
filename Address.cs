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
            //Countries country;
        }
        /// <summary>
        /// constroctor
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        public Address(string street, string city, string postCode): this ()
        {
            this.street = street;
            this.city = city;
            this.postCode = postCode;
        }

        /// <summary>
        /// constroctor
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        /// <param name="country"></param>
        public Address(string street, string city, string postCode, Countries country) : this(street, city, postCode)//chain-calling the other constarctor.
        {
            this.country = country;
        }

        /// <summary>
        /// Property get and set the street name
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// Poperty, get na dset the city name
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }

            set
            {
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

        //Methods

        public bool validateCity(string city)
        {
            bool ok = !string.IsNullOrEmpty(city);
            return ok;
        }

        public string addressToString()
        {
            validateCity(this.city);
            string address;
            address = string.Format("{0, -25} {1, -8} {2, -10} {3}", street, city, postCode, country.ToString());//you can write a getCounteryString() method to rempve the _. using the keyword replace. 
            return address;
        }
    }
}
