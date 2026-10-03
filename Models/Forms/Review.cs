namespace Salinto.Models;

public record Review(
    int CompanyId,
    string JobTitle,
    EmploymentType EmploymentType,
    DateOnly SubmittedOn,
    int Rating,
    string Body,
    int HelpfulCount);
