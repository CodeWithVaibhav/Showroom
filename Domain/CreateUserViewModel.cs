namespace Showroom.Domain
{
    public class CreateUserViewModel
    {
        public string LDAPPath { get; set; }
        public string UserName { get; set; }
        public string Initials{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string TelephoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
