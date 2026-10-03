using Salinto.Models;

namespace Salinto.Util;

public static class EmploymentTypeExtensions
{
    public static string ToLabel(this EmploymentType employmentType) => employmentType switch
    {
        EmploymentType.DirectHire => "Direct hire",
        EmploymentType.AgencyHired => "Agency hired",
        EmploymentType.ProjectBased => "Project based",
        _ => employmentType.ToString()
    };
}
