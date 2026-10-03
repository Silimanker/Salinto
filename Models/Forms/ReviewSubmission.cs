using System.ComponentModel.DataAnnotations;

namespace Salinto.Models.Forms;

public class ReviewSubmission
{
    [Required(ErrorMessage = "Enter the job title you held.")]
    public string JobTitle { get; set; } = "";

    public EmploymentType EmploymentType { get; set; } = EmploymentType.DirectHire;

    [Range(1, 5, ErrorMessage = "Choose a rating from 1 to 5.")]
    public int Rating { get; set; } = 3;

    [Required(ErrorMessage = "Write a few sentences about your experience.")]
    [MinLength(30, ErrorMessage = "Please write at least 30 characters.")]
    public string Body { get; set; } = "";
}