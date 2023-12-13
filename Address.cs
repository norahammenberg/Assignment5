using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Address
    {
        private string street = string.Empty;
        private string city = String.Empty;
        private string postCode = String.Empty;
        private Countries country;

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
    }
}
