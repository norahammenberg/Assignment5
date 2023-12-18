namespace Assignment5
{
    public partial class MainForm : Form
    {
        EventManager eventManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeUI();
        }
        ///creating an UI that is empty
        private void InitializeUI()
        {
            //adding the enum to the combo box
            comboBoxCountry.DataSource = Enum.GetValues(typeof(Countries));
            groupBoxInvite.Enabled = false;

            textBoxCostPerson.Text = String.Empty;
            textBoxFeePerson.Text = String.Empty;
            textBoxFirstName.Text = String.Empty;
            textBoxLastName.Text = String.Empty;
            guestList.Items.Clear();
            labelNumGuest.Text = "                              ";
            labelTotalCost.Text = "                              ";
            labelTotalFee.Text = "                              ";
            labelSurplus.Text = "                              ";
        }
        /// <summary>
        /// read the cost per person added by the user
        /// </summary>
        /// <returns></returns>
        private bool readCostPerPerson()
        {
            double amount = 0.0;
            bool ok = true;
            if (double.TryParse(textBoxCostPerson.Text, out amount) && (amount >= 0.0))
            {
                eventManager.CostPerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid");
                ok = false;
            }
            return ok;
        }
        /// <summary>
        /// read the fee per person added by the user

        /// </summary>
        /// <returns></returns>
        private bool readFeePerPerson()
        {
            double amount = 0.0;
            bool ok = true;
            if (double.TryParse(textBoxFeePerson.Text, out amount) && (amount >= 0.0))
            {
                eventManager.FeePerPerson = amount;
            }
            else
            {
                MessageBox.Show("Invalid");
                ok = false;
            }
            return ok;
        }

        /// <summary>
        /// creating the event. when the user have named the event and given the cost and fee the event is created and the groupbox for filling in name and address is enabler. 
        ///Checking that the cast and fee is okay and that a title is filedin
        /// </summary>
        private void createEvent()
        {
            //cearing an new object of the eventManager:
            eventManager = new EventManager();
            if (string.IsNullOrEmpty(textBoxEventTitle.Text))
            {
                textBoxEventTitle.Text = "Untitled Event";
            }

            bool costOK = readCostPerPerson();
            bool feeOK = readFeePerPerson();

            if (costOK && feeOK)//if it is all ok the event is created and UI is updated
            {
                groupBoxInvite.Enabled = true;
                MessageBox.Show("Event created");
                updateUI();
            }
        }
        /// <summary>
        /// method that updats the UI 
        /// creates an array with the participant info from participant mamanger. 
        /// if the array is npot null it clears the list and add all the added participants. 
        /// calculats all the cast that is realted to the party.
        /// </summary>
        private void updateUI()
        {
            string[] arrayParInfor = eventManager.participant.getParticipantsInfo();//calling the get particapant info from the participant manager class
            if (arrayParInfor != null)
            {
                guestList.Items.Clear();
                guestList.Items.AddRange(arrayParInfor);
                labelNumGuest.Text = guestList.Items.Count.ToString();
            }
            //calculated all the costs
            double totalCost = eventManager.calcTotalCost();
            labelTotalCost.Text = totalCost.ToString("0.00");
            labelNumGuest.Text = guestList.Items.Count.ToString();

            double totalFee = eventManager.calcTotalFee();
            labelTotalFee.Text = totalFee.ToString("0.00");
            labelSurplus.Text = (totalFee - totalCost).ToString("0.00");
        }
        /// <summary>
        /// when the user clicks add a new participant is created and the UI is updated, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Participant participant = new Participant();//we create a new particapant
            if (readInput(ref participant))
            {
                updateUI();
            }
        }
        /// <summary>
        /// reads all the input from the user 
        /// if the user info is ok they above method can be use if the user have not filled in requered fields they get a messegebox asking them to fill them in
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        private bool readInput(ref Participant participant)
        {
            bool ok = readParData(ref participant);
            if (ok)
            {
                eventManager.participant.addParticipant(participant);
            }
            else
            {
                MessageBox.Show("First name, last name and City i requered.");
            }
            return ok;
        }
        /// <summary>
        /// readall the infor inputed by the user and validate both name and address. and triming any access of on the name input. 
        /// if the inputs are okay the user can move on with next step meaning adding the participant to the list. 
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        private bool readParData(ref Participant participant)
        {
            //participant gets its firstname  and lastname
            participant.FirstName = textBoxFirstName.Text.Trim();
            participant.LastName = textBoxLastName.Text.Trim();

            Address address = readAddress();
            participant.Address = address; // adding the address to the participant. 
            bool nameOk = participant.validateParticipant();
            bool ok = address.validateCity();
            return ok && nameOk;
        }

        /// <summary>
        /// reading the address inputed by the user and creating a new object of the adrres class. 
        /// </summary>
        /// <returns>the address</returns>
        private Address readAddress()
        {
            Address address = new Address();
            address.Street = textBoxStreet.Text;
            address.City = textBoxCity.Text;
            address.PostCode = textBoxPostCode.Text;
            address.Country = (Countries)comboBoxCountry.SelectedIndex;

            return address;
        }

        /// <summary>
        /// crating the event when the user click on creat event calling create event class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            guestList.Items.Clear();
            createEvent();
        }
        /// <summary>
        /// allowing the user to selcet an item in the list box to be changed or dealeted. 
        /// if indext on selected item is greater then null a new participant with thi participant is created and added to the input feaild so that the user can change the name sct. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = guestList.SelectedIndex;//get the selected indext by the user

            if (index >= 0)
            {
                Participant participant = eventManager.participant.getParticipant(index);

                textBoxFirstName.Text = participant.FirstName;
                textBoxLastName.Text = participant.LastName;
                textBoxStreet.Text = participant.Address.Street;
                textBoxCity.Text = participant.Address.City;
                textBoxPostCode.Text = participant.Address.PostCode;

                comboBoxCountry.SelectedIndex = (int)participant.Address.Country;
            }
            else
                MessageBox.Show("Selected an item!");//if no item is selected messagebox pops up asking user to selected an itemö 
        }

        /// <summary>
        /// when the user clicks the change button the selected item in the list box is chaned with correstondedn input itn the input feilds. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = guestList.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            Participant participant = eventManager.participant.getParticipant(index);

            if (readParData(ref participant))
            {
                eventManager.participant.changeParticipant(participant, index);
                updateUI();//updating UI with the new changed name address or city. 
            }
        }
        /// <summary>
        /// when the user have selected an item in the list box this item is removed from the list when this buttun is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = guestList.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            Participant participant = eventManager.participant.getParticipant(index);
            eventManager.participant.deleteParticipant(index);
            updateUI();

        }
    }
}