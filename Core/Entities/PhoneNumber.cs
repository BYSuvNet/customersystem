namespace CustomerSystem.Core.Entities;

public record PhoneNumber(string CountryCode, string Number)
{
    public string CountryCode { get; init; } =
        !string.IsNullOrWhiteSpace(CountryCode) && CountryCode.All(char.IsDigit) ? CountryCode.Trim()
        : throw new ArgumentException("Invalid country code");

    public string Number { get; init; } =
        !string.IsNullOrWhiteSpace(Number) && Number.All(char.IsDigit) ? Number.Trim()
        : throw new ArgumentException("Invalid phone number");

    public string Full => $"+{CountryCode} {Number}";
}