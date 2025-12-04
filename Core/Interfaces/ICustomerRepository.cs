using CustomerSystem.Core.Entities;

namespace CustomerSystem.Core.Interfaces;

public interface ICustomerRepository
{
    Customer? GetById(int id);
    void Add(Customer customer);
    IEnumerable<Customer> GetAll();
    void Remove(int id);
}