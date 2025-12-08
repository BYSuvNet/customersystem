using CustomerSystem.Core.Entities;
using CustomerSystem.Core.Interfaces;
using CustomerSystem.UI;

public class RemoveCustomerView(ICustomerRepository repo) : IView
{
    ICustomerRepository customerRepo = repo;

    public string Title => "Radera kunder";

    public void Show()
    {
        IEnumerable<Customer> customers = customerRepo.GetAll();

        List<string> customerNames = [];

        foreach (var c in customers)
        {
            customerNames.Add(c.Name.Full);
        }

        //Alternativ med LINQ
        //string[] customerNamesArray = customers.Select(c => c.Name.Full).ToArray();

        int selected = ArrowMenu.Show("Kunder", customerNames.ToArray());

        if (selected >= 0)
        {
            List<Customer> customersAsList = customers.ToList();
            Customer customerToDelete = customersAsList[selected];
            int idToDelete = customerToDelete.Id;
            customerRepo.Remove(idToDelete);

            Console.WriteLine("\n Kund borttagen!");

            // Eller mer kompakt:
            //customerRepo.Remove(customers.ToList()[selected].Id);
        }
        else
        {
            Console.WriteLine("Avbryter, tryck på enter för att fortsätta.");
        }

        Console.ReadLine();
    }
}