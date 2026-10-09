namespace Salinto.Models;

public record ComplianceItem(
    int CompanyId,
    string Description,
    int ReportedCompliantCount,
    int ReviewerCount)
{
    public int Id { get; init; }

    public int CompliantPercent => ReviewerCount == 0 ? 0 : ReportedCompliantCount * 100 / ReviewerCount;
}
