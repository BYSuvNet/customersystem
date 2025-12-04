using CustomerSystem.Core.Interfaces;
using CustomerSystem.Core.Entities;

namespace CustomerSystem.UI.Views;

public class ListAllCustomersView(ICustomerRepository repo) : IView
{
    ICustomerRepository customerRepo = repo;

    public void Show()
    {
        Console.Clear();
        Console.WriteLine("-- ALLA KUNDER: --");

        IEnumerable<Customer> customers = repo.GetAll();

        if (!customers.Any())
        {
            Console.WriteLine("Finns inga kunder än :(");
        }

        foreach (var item in customers)
        {
            Console.WriteLine($"{item.Name.Full}");
        }

        Console.WriteLine("\nTryck på valfri knapp för att fortsätta");
        Console.ReadLine();
    }
}