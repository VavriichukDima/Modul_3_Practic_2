namespace Modul_3_Practic_2
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + LastName;
        public string PhoneNumber { get; set; }
    }
}
