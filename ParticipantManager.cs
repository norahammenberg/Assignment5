using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ParticipantManager
    {
        private List<Participant> participants; // dynamic list and grows while the user add a new participant. 

        /// <summary>
        /// constructor that creates a new list of participantce.
        /// </summary>
        public ParticipantManager() 
        {
            participants = new List<Participant>();
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
