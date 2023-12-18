using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class EventManager
    {
        //instance variables
        private double costPerPerson;
        private double feePerPerson;
        private string title = String.Empty;

        //creating an object of the participant manager
        ParticipantManager participantManager = new ParticipantManager();

        /// <summary>
        /// default constrictor that creating a new object of the particiant class. 
        /// </summary>
        public EventManager() 
        {
            participantManager = new ParticipantManager();//we creating the object of the participant manager. 
        }

        /// <summary>
        /// properties getting the participant, this is read only and other members can not access this one.
        /// </summary>
        public ParticipantManager participant 
        { 
            //read only because no other classes should use this object.
            get { return participantManager; } 
        }
        /// <summary>
        /// property for the title get and set
        /// </summary>
        public string Title
        {
            get { return title; }
            set { 
                if(!string.IsNullOrEmpty(value))//cheking so it is not null or empty.
                    title = value; 
            }
        }
        /// <summary>
        /// property get and set the cost
        /// </summary>
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set 
            { 
                if ( value >= 0.0)//checking so the value is more the 0.0
                    costPerPerson = value; 
            }
        }
        /// <summary>
        /// property get and set for fee
        /// </summary>
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set 
            {
                if (value >= 0.0) //checking that the valuen is not more the 0.0
                    feePerPerson = value; 
            }
        }

        /// <summary>
        /// calulationg the cost of the party
        /// </summary>
        /// <returns></returns>
        public double calcTotalCost()
        {
            return participantManager.Count * costPerPerson;
        }
        /// <summary>
        /// calculating the fees of the party
        /// </summary>
        /// <returns></returns>
        public double calcTotalFee()
        {
            return participantManager.Count * feePerPerson;
        }
    }
}
