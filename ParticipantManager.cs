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

        /// <summary>
        /// get participantes, instead of using a getter and seter properties we using this method. 
        /// Checking if the list is less the 0 or higher or equl to the participantlist lenght. return a null Participant if it is. 
        /// If not create an array with the length of index. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Participant getParticipant (int index)
        {
            if (index < 0 || index >= participants.Count) 
            {
                return null;
            }
            return participants[index];//returning the participant with corespondig index
        }

        /// <summary>
        /// Counted the number of participants regestereted in the element. 
        /// </summary>
        public int Count 
        { 
            get { return participants.Count; } 
        }
        /// <summary>
        /// adding a participant to the party by using the built un method add to the List. adding the created participant by the user. 
        /// </summary>

        /// <returns></returns>
        public bool addParticipant(Participant participant)
        { 
            participants.Add(participant); //to the participants list add the new participant. 
            return true; 
        }
    /// <summary>
    /// the method that chaning an participant. if the participant is not null and theindex seleced by the user is more the 0 but less the participant count
    /// allow the user to change that participant by using the same feails as when adding a new participant and replacing the selected place in the lsi twith this new changed participant. 
    /// </summary>
    /// <param name="participant"></param>
    /// <param name="index"></param>
    /// <returns></returns>
        public bool changeParticipant( Participant participant, int index )
        {
            bool ok = true;
            if (participant != null && index < 0 || index >= participants.Count)
            {
                participants[index] = participant;
            }
            else
            {
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// deleting an participant, using the list åroperty removeAt, 
        /// as the list is dynamic we don't need to move particiapants in the list. the list only excisit of the participants that is registratdes.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool deleteParticipant(int index)
        {
            if (index < 0 || index >= participants.Count)
            {
                return false;
            }
            else
            { 
                participants.RemoveAt(index);//removing participant on picked index.
                return true;
            }
           
        }
        /// <summary>
        /// getting all the infor from all added participants. creating an arrya ta add the participants to. 
        /// looping through them to display them in the list box. 
        /// </summary>
        /// <returns></returns>
        public string[] getParticipantsInfo()
        {
            string[] strInfoString = new string[participants.Count]; //new array of the participant that is registered. 
            
            int i = 0;
            
            //looping through the object in the array and making every object to a sting.
            foreach ( Participant participantObj in participants )
            {
                strInfoString[i++] = participantObj.ToString();
            }
            return strInfoString;
        }
    }
}
