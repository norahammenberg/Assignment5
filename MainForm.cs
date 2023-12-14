namespace Assignment5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private ParticipantManager part = new ParticipantManager();
        private bool readStreet()
        {
            bool ok = true;
            string street = "Providance Ave";
            part.Address.Street = street;
            string city = "Leeds";
            part.Address.City = city;
            string post = "LS6 2HN";
            part.Address.PostCode = post;
            string firstNAme = "Nora";
            part.FirstName = firstNAme;
            string lastNAme = "Hammenberg";
            part.LastName = lastNAme;
            return ok;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            readStreet();
            part.fullParticapantToString();
            //part.Address.addressToString();
        }
    }
}