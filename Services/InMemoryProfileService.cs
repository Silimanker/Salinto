using Salinto.Models;

namespace Salinto.Services;

public class InMemoryProfileService : IProfileService
{
    private UserProfile currentProfile = new()
    {
        DisplayName = "Juan Dela Cruz",
        Location = "Cebu City, Philippines",
        Bio = "Software developer with 4 years in BPO and tech startups in Metro Cebu.",
        EmailNotificationsEnabled = true,
        WeeklyDigestEnabled = false
    };

    // Hands out copies so unsaved edits never change the stored profile.
    public Task<UserProfile> GetProfileAsync() => Task.FromResult(currentProfile.Copy());

    public Task SaveProfileAsync(UserProfile updatedProfile)
    {
        currentProfile = updatedProfile.Copy();
        return Task.CompletedTask;
    }
}
