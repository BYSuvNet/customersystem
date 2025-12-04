using CustomerSystem.Core.Entities;
using CustomerSystem.Core.Interfaces;

public class DapperCustomerRepository : ICustomerRepository
{


    public DapperCustomerRepository(string connectiongString)
    {

    }

    public void Add(Customer customer)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public Customer? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }
}