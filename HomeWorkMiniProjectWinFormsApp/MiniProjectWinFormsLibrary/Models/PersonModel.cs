namespace HomeWorkMiniProjectWinForms.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel Address { get; set; }
        public string FullInformation { get; set; }

        public void FullPersonInformation()
        {
            FullInformation = $"{FirstName} {LastName} {Address.Street} {Address.Number} {Address.PostalCode} {Address.City}";
        }
    }
}
