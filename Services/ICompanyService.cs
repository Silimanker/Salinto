using Salinto.Models;
using Salinto.Models.Forms;

namespace Salinto.Services;

public interface ICompanyService
{
    Task<IReadOnlyList<Company>> SearchCompaniesAsync(string? searchText);
    Task<IReadOnlyList<Company>> GetCompaniesByIdsAsync(IEnumerable<int> companyIds);
    Task<Company?> GetCompanyByIdAsync(int companyId);

    Task<IReadOnlyList<Review>> GetReviewsAsync(int companyId, EmploymentType? employmentType);
    Task<IReadOnlyList<SalaryEntry>> GetSalaryEntriesAsync(int companyId, EmploymentType? employmentType);
    Task<IReadOnlyList<ComplianceItem>> GetComplianceItemsAsync(int companyId);

    Task AddReviewAsync(int companyId, ReviewSubmission submission);
}
