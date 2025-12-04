namespace CustomerSystem.Core.Entities;

public record Name(string First, string Last)
{
    public string First { get; init; } =
        !string.IsNullOrWhiteSpace(First) ? First.Trim()
        : throw new ArgumentException("First name cannot be empty");

    public string Last { get; init; } =
        !string.IsNullOrWhiteSpace(Last) ? Last.Trim()
        : throw new ArgumentException("Last name cannot be empty");

    public string Full => $"{First} {Last}";
}
