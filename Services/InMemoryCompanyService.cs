using Salinto.Models;
using Salinto.Models.Forms;

namespace Salinto.Services;

public class InMemoryCompanyService : ICompanyService
{
    private static readonly List<Company> companies =
    [
        new(1, "TechPulse Philippines Inc.", "TP", "IT and BPO services", "Bonifacio Global City, Taguig", 4.2, 128),
        new(2, "MetroBank Solutions", "MB", "Banking and finance", "Makati City", 4.5, 64),
        new(3, "Visayas Freight and Logistics", "VF", "Logistics", "Mandaue City, Cebu", 3.6, 41),
        new(4, "Pacific Contact Partners", "PC", "Customer support (BPO)", "IT Park, Cebu City", 3.9, 212),
        new(5, "Luzon Builders Corp.", "LB", "Construction", "Pasig City", 3.4, 27)
    ];

    private static readonly List<Review> reviews =
    [
        new(1, "Mid-level backend developer", EmploymentType.DirectHire, new DateOnly(2026, 9, 18), 4,
            "HMO covers two dependents from day one. 13th-month pay is always released before December 15. Release cycles get heavy, but overtime is tracked accurately and paid on time.", 14),
        new(1, "Technical support specialist", EmploymentType.AgencyHired, new DateOnly(2026, 8, 30), 3,
            "Benefits go through the partner agency. Night differential is paid, but onboarding took longer than expected. A fair first job for BPO IT operations.", 8),
        new(5, "Site engineer", EmploymentType.ProjectBased, new DateOnly(2026, 7, 21), 3,
            "Pay is good for the length of the project, but there is no clear plan for what happens when it ends. Safety gear was always provided.", 5)
    ];

    private static readonly List<SalaryEntry> salaryEntries =
    [
        new(1, "Software engineer", EmploymentType.DirectHire, 12, 42000, 55000, 78000),
        new(1, "QA analyst", EmploymentType.DirectHire, 8, 30000, 38000, 48000),
        new(1, "Customer support rep", EmploymentType.AgencyHired, 15, 22000, 26500, 31000),
        new(5, "Site engineer", EmploymentType.ProjectBased, 6, 32000, 41000, 52000)
    ];

    private static readonly List<ComplianceItem> complianceItems =
    [
        new(1, "SSS, PhilHealth and Pag-IBIG remitted", 19, 21),
        new(1, "13th-month pay released on time", 20, 21),
        new(1, "Overtime and night differential paid", 16, 21)
    ];

    public Task<IReadOnlyList<Company>> SearchCompaniesAsync(string? searchText)
    {
        var term = searchText?.Trim() ?? "";

        var matches = companies.Where(company =>
            term.Length == 0
            || company.Name.Contains(term, StringComparison.OrdinalIgnoreCase)
            || company.Industry.Contains(term, StringComparison.OrdinalIgnoreCase)
            || company.Location.Contains(term, StringComparison.OrdinalIgnoreCase));

        return Task.FromResult<IReadOnlyList<Company>>(matches.OrderByDescending(company => company.ReviewCount).ToList());
    }

    public Task<IReadOnlyList<Company>> GetCompaniesByIdsAsync(IEnumerable<int> companyIds) =>
        Task.FromResult<IReadOnlyList<Company>>(companies.Where(company => companyIds.Contains(company.Id)).ToList());

    public Task<Company?> GetCompanyByIdAsync(int companyId) =>
        Task.FromResult(companies.FirstOrDefault(company => company.Id == companyId));

    public Task<IReadOnlyList<Review>> GetReviewsAsync(int companyId, EmploymentType? employmentType) =>
        Task.FromResult<IReadOnlyList<Review>>(reviews
            .Where(review => review.CompanyId == companyId && (employmentType is null || review.EmploymentType == employmentType))
            .ToList());

    public Task<IReadOnlyList<SalaryEntry>> GetSalaryEntriesAsync(int companyId, EmploymentType? employmentType) =>
        Task.FromResult<IReadOnlyList<SalaryEntry>>(salaryEntries
            .Where(entry => entry.CompanyId == companyId && (employmentType is null || entry.EmploymentType == employmentType))
            .ToList());

    public Task<IReadOnlyList<ComplianceItem>> GetComplianceItemsAsync(int companyId) =>
        Task.FromResult<IReadOnlyList<ComplianceItem>>(complianceItems.Where(item => item.CompanyId == companyId).ToList());

    public Task AddReviewAsync(int companyId, ReviewSubmission submission)
    {
        reviews.Insert(0, new Review(
            companyId,
            submission.JobTitle.Trim(),
            submission.EmploymentType,
            DateOnly.FromDateTime(DateTime.Today),
            submission.Rating,
            submission.Body.Trim(),
            HelpfulCount: 0));

        return Task.CompletedTask;
    }
}
