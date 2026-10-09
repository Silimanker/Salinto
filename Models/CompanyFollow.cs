namespace Salinto.Models;

public class CompanyFollow
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public int CompanyId { get; set; }

    public DateTime FollowedOn { get; set; }
}
