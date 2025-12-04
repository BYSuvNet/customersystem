using CustomerSystem.Core.Entities;
using CustomerSystem.Core.Interfaces;

public class InMemoryCustomerRepository : ICustomerRepository
{
    List<Customer> _customers = [new Customer(new Name("Kalle", "Anka"), new Email("test@test.com"), new PhoneNumber("46", "0701234567")){Id = 1},
                                 new Customer(new Name("Olle", "Långstrump"), new Email("1@test.com"), new PhoneNumber("46", "0707654321")){Id = 2},
                                 new Customer(new Name("Mimmi", "Pigg"), new Email("olle@langstromp.com"), new PhoneNumber("46", "0731234567")){Id = 3}
                                ];

    public Customer? GetById(int id)
    {
        foreach (Customer c in _customers)
        {
            if (c.Id == id)
            {
                return c;
            }
        }

        return null;
    }

    public void Add(Customer customer)
    {
        customer.Id = Random.Shared.Next();
        _customers.Add(customer);
    }

    public IEnumerable<Customer> GetAll()
    {
        return _customers;
    }

    public void Remove(int id)
    {
        Customer? customerToDelete = GetById(id);
        if (customerToDelete != null)
        {
            _customers.Remove(customerToDelete);
        }
    }
}