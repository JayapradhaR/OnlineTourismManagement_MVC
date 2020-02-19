
namespace OnlineTourismManagement.Entity
{
    public enum Role
    {
        User,
        Admin
    }
    public class UserDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long MobileNumber { get; set; }
        public string Gender { get; set; }
        public string MailId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Role UserRole { get; set; }
        public UserDetails()
        { }

        public UserDetails(string firstName, string lastName, long mobileNumber, string gender, string mailId, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            Gender = gender;
            MailId = mailId;
            Password = password;
        }
    }
}
