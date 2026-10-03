using Salinto.Models;

namespace Salinto.Services;

public interface IUserActivityService
{
    Task<IReadOnlyList<int>> GetFollowedCompanyIdsAsync();
    Task<bool> IsFollowingAsync(int companyId);
    Task ToggleFollowAsync(int companyId);

    Task<IReadOnlyList<Contribution>> GetContributionsAsync();
    Task AddContributionAsync(Contribution contribution);
}
