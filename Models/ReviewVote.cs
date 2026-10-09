namespace Salinto.Models;

public class ReviewVote
{
    public int Id { get; set; }

    public int ReviewId { get; set; }
    public int UserId { get; set; }

    public DateTime VotedOn { get; set; }
}
