using Salinto.Models;

namespace Salinto.Services;

public class InMemoryUserActivityService : IUserActivityService
{
    private readonly List<int> followedCompanyIds = [1, 2];

    private readonly List<Contribution> contributions =
    [
        new("Review of TechPulse Philippines", "4 of 5, direct hire. Sep 18, 2026"),
        new("Salary report, Software engineer", "₱55,000 a month. Aug 12, 2026")
    ];

    public Task<IReadOnlyList<int>> GetFollowedCompanyIdsAsync() =>
        Task.FromResult<IReadOnlyList<int>>(followedCompanyIds.ToList());

    public Task<bool> IsFollowingAsync(int companyId) => Task.FromResult(followedCompanyIds.Contains(companyId));

    public Task ToggleFollowAsync(int companyId)
    {
        if (!followedCompanyIds.Remove(companyId))
            followedCompanyIds.Add(companyId);

        return Task.CompletedTask;
    }

    public Task<IReadOnlyList<Contribution>> GetContributionsAsync() =>
        Task.FromResult<IReadOnlyList<Contribution>>(contributions.ToList());

    public Task AddContributionAsync(Contribution contribution)
    {
        contributions.Insert(0, contribution);
        return Task.CompletedTask;
    }
}
