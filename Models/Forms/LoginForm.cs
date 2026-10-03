using System.ComponentModel.DataAnnotations;

namespace Salinto.Models.Forms;

public class LoginForm
{
    [Required(ErrorMessage = "Enter your username or email.")]
    public string UsernameOrEmail { get; set; } = "";

    [Required(ErrorMessage = "Enter your password.")]
    public string Password { get; set; } = "";
}
