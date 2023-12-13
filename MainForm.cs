namespace Assignment5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private Address address = new Address();
        private bool readStreet()
        {
            bool ok = true;
            string street = "Providance Ave";
            address.Street = street;
            string city = "Leeds";
            address.City = city;
            string post = "LS6 2HN";
            address.PostCode = post;

            return ok;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            readStreet();
            address.addressToString();
        }
    }
}