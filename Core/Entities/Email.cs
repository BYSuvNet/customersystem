namespace CustomerSystem.Core.Entities;

public record Email(string Address)
{
    public string Address { get; } =
        !string.IsNullOrWhiteSpace(Address) && Address.Contains('@') ? Address.Trim()
        : throw new ArgumentException("Invalid email address");
}
