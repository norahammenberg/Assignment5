using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Address
    {
        private string street;
        private string city;
        private string postCode;
        private Countries country;

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
        public Address(string street, string city, string postCode, Countries country) : this(street, city, postCode)
        {
            this.country = country;
        }

        /// <summary>
        /// Property get and set the street name
        /// </summary>
        public string Street
        {
            get
            {
                return street;
            }

            set
            {
              street = value;
            }
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
                city = value;
            }
        }

        /// <summary>
        /// Property to get and set post code
        /// </summary>
        public string PostCode
        {
            get
            {
                return postCode;
            }

            set
            {
                postCode = value;
            }
        }

        /// <summary>
        /// Property to set and get the counteries. 
        /// </summary>
        public Countries Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }
        public bool validateCity(string city)
        {
            bool ok = !string.IsNullOrEmpty(city);
            return ok;
        }

        public string addressToString()
        {
            validateCity(this.city);
            string address;
            address = street + city + postCode;
            return address;
        }
    }
}
