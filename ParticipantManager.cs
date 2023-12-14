using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ParticipantManager
    {
        //instance variable
        private List<Participant> participants; // dynamic list and grows when the user add a new participant and shrinks when the user delere an participant

        /// <summary>
        /// constructor that creates a new list of participantce.
        /// </summary>
        public ParticipantManager() 
        {
            participants = new List<Participant>();// we create a a new list
        }
        //method to handle a list

        public Participant getParticipant (int index)
        {
            if (index < 0 || index >= participants.Count)
            {
                return null;
            }
            return participants[index];

            // returning a copy instead??? 33.17
            // calling the copy constroctor and creating a copyy if the object. 
        }
        public int Count 
        { 
            get 
            { 
                return participants.Count;
            } 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool addParticipant(string firstName, string lastName, Address address)
        {
            Participant newParticipant = new Participant(firstName, lastName, address);
            participants.Add(newParticipant);
            return true;
        }
        public string[] getParticipantsInfo()
        {

            
            participants.fullParticapantToString();
            int count = participants.Count;
            return participants.ToArray();
        }
    }
}
