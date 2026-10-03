using System.ComponentModel.DataAnnotations;

namespace Salinto.Models.Forms;

public class RegisterForm
{
    [Required(ErrorMessage = "Enter your first name.")]
    public string FirstName { get; set; } = "";

    [Required(ErrorMessage = "Enter your last name.")]
    public string LastName { get; set; } = "";

    [Required(ErrorMessage = "Choose a username.")]
    [MinLength(3, ErrorMessage = "Use at least 3 characters.")]
    public string Username { get; set; } = "";

    [Required(ErrorMessage = "Enter your email address.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Enter a password.")]
    [MinLength(8, ErrorMessage = "Use at least 8 characters.")]
    public string Password { get; set; } = "";
}
