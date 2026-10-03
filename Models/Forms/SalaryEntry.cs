namespace Salinto.Models;

public record SalaryEntry(
    int CompanyId,
    string JobTitle,
    EmploymentType EmploymentType,
    int ReportCount,
    int MinimumMonthly,
    int MedianMonthly,
    int MaximumMonthly);
