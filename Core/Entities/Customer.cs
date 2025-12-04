namespace CustomerSystem.Core.Entities;

public class Customer(Name name, Email email, PhoneNumber phoneNumber)
{
    public int Id { get; set; }
    public Name Name { get; set; } = name;
    public Email Email { get; set; } = email;
    public PhoneNumber PhoneNumber { get; set; } = phoneNumber;
}
