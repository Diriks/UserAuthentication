using System.ComponentModel.DataAnnotations;

namespace UserAuthentication.Models
{
    public class UserModel
    {
        public string Id { set; get; }
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { set; get; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Required(ErrorMessage = "Please enter Email")]
        public string Email { set; get; }

        [Required(ErrorMessage = "Please enter Password")]
        public string Password { set; get; }

        [Compare("Password", ErrorMessage = "Password does not match")]
        [Required(ErrorMessage = "Please re-enter Password")]
        public string ConfirmPassword { set; get; }

        [RegularExpression("^\\d{9}$", ErrorMessage = "Please enter a correct phone number")]
        public string Contact { set; get; }


    }
}
