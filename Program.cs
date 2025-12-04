using CustomerSystem.Core.Interfaces;
using CustomerSystem.UI;
using CustomerSystem.UI.Views;

ICustomerRepository customerRepository = new InMemoryCustomerRepository();
// ICustomerRepository customerRepository = new DapperCustomerRepository("minConnectionString");

IView[] views = [new AddCustomerView(), new ListAllCustomersView(customerRepository), new RemoveCustomerView(customerRepository)];
string[] menuOptions = ["Lägg till kund", "Visa alla kunder", "Ta bort kund"];

while (true)
{
    int choice = ArrowMenu.Show("Huvudmeny", menuOptions);

    if (choice == -1) break;

    views[choice].Show();
}