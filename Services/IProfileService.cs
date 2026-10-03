using Salinto.Models;

namespace Salinto.Services;

public interface IProfileService
{
    Task<UserProfile> GetProfileAsync();
    Task SaveProfileAsync(UserProfile updatedProfile);
}
