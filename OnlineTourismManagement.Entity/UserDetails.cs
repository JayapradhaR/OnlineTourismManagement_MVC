
using System.ComponentModel.DataAnnotations;

namespace OnlineTourismManagement.Entity
{
    public enum Role
    {
        User,
        Admin
    }
    public class UserDetails
    {
        [Required]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage ="Enter valid name")]
        [MaxLength(30)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number required")]
        [DataType(DataType.PhoneNumber)]
        public long MobileNumber { get; set; }

        [Required(ErrorMessage="Gender required")]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Mail id required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage="Enter valid email id")]
        public string MailId { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and Confirm password must be same")]
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
