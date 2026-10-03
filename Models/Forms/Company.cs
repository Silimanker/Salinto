namespace Salinto.Models;

public record Company(
    int Id,
    string Name,
    string Initials,
    string Industry,
    string Location,
    double AverageRating,
    int ReviewCount);
