using HomeWorkMiniProjectWinForms.Models;
using System.ComponentModel;

namespace HomeWorkMiniProjectWinForms
{
    public partial class PersonalInfoUI : Form
    {
        public BindingList<PersonModel> Persons { get; set; } = new();
        public PersonModel Person { get; set; } = new() { Address = new AddressModel() };

        public PersonalInfoUI()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            addressListBox.DataSource = Persons;
            addressListBox.DisplayMember = "FullInformation";
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            string lastEntryFirstName = "";
            if (Persons.Count() > 0)
            {
                lastEntryFirstName = Persons.Last().FirstName;
            }

            if (Person.FirstName != "<firstname>" || lastEntryFirstName != "<firstname>")
            {
                var addressInfoUI = new AddressInfoUI();
                addressInfoUI.ShowDialog();
                Person = new() { Address = new AddressModel() };

                Person.Address.Street = addressInfoUI.Street;
                Person.Address.Number = addressInfoUI.Number;
                Person.Address.PostalCode = addressInfoUI.PostalCode;
                Person.Address.City = addressInfoUI.City;

                if (string.IsNullOrEmpty(Person.FirstName))
                {
                    Person.FirstName = "<firstname>";
                }
                if (string.IsNullOrEmpty(Person.LastName))
                {
                    Person.LastName = "<lastname>";
                }
                if (string.IsNullOrEmpty(Person.Address.Street) == false)
                {
                    Person.FullPersonInformation();
                    Persons.Add(Person);
                }
            }
            else
            {
                MessageBox.Show("Save names to current address first.", "Missing first and last name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePersonButton_Click(object sender, EventArgs e)
        {

            string lastEntryFirstName = "";
            if (Persons.Count() > 0)
            {
                lastEntryFirstName = Persons.Last().FirstName;
            }

            if (Persons.Count >= 1 && lastEntryFirstName == "<firstname>")
            {
                if (string.IsNullOrEmpty(firstNameTextBox.Text))
                {
                    MessageBox.Show("Fill in a valid first name.", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    firstNameTextBox.Focus();
                }
                if (string.IsNullOrEmpty(lastNameTextBox.Text))
                {
                    MessageBox.Show("Fill in a valid last name.", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lastNameTextBox.Focus();
                }
                if (string.IsNullOrEmpty(Person.Address.Street))
                {
                    MessageBox.Show("Add address first.", "Invalid address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrEmpty(firstNameTextBox.Text) == false &&
                    string.IsNullOrEmpty(lastNameTextBox.Text) == false &&
                    string.IsNullOrEmpty(Person.Address.Street) == false)
                {
                    Person.FirstName = firstNameTextBox.Text;
                    Person.LastName = lastNameTextBox.Text;
                    Person.FullPersonInformation();
                    addressListBox.DataSource = null;
                    addressListBox.DataSource = Persons;
                    addressListBox.DisplayMember = "FullInformation";
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    lastNameTextBox.Focus();
                    Person = new() { Address = new AddressModel() };
                }
            }
            else
            {
                MessageBox.Show("No address to save names to.", "Missing address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Persons.Count >= 1)
            {
                Persons.Remove(Persons[addressListBox.SelectedIndex]);
            }
        }
    }
}