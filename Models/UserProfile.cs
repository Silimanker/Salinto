using System.ComponentModel.DataAnnotations;

namespace Salinto.Models;

public class UserProfile
{
    public int UserId { get; set; }

    [Required(ErrorMessage = "Enter a display name.")]
    public string DisplayName { get; set; } = "";

    public string Location { get; set; } = "";

    [MaxLength(300, ErrorMessage = "Keep it to 300 characters or fewer.")]
    public string Bio { get; set; } = "";

    public bool EmailNotificationsEnabled { get; set; }
    public bool WeeklyDigestEnabled { get; set; }

    public UserProfile Copy() => (UserProfile)MemberwiseClone();
}
