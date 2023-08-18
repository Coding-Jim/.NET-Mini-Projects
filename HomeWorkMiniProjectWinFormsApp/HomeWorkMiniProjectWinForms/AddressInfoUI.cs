namespace HomeWorkMiniProjectWinForms
{
    public partial class AddressInfoUI : Form
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }


        public AddressInfoUI()
        {
            InitializeComponent();
        }

        private void SaveAddressButton_Click(object sender, EventArgs e)
        {
            bool isValidInt = int.TryParse(numberTextBox.Text, out int numberInt);

            if (string.IsNullOrEmpty(streetTextBox.Text) ||
                string.IsNullOrEmpty(postalCodeTextBox.Text) ||
                string.IsNullOrEmpty(cityTextBox.Text))
            {
                MessageBox.Show("This is not a valid Address, please fill in all fields", "Invalid address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (isValidInt == false)
            {
                MessageBox.Show("This is not a valid number, please use numbers only", "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Street = streetTextBox.Text;
                Number = numberInt;
                PostalCode = postalCodeTextBox.Text;
                City = cityTextBox.Text;

                Close();
            }
        }
    }
}
