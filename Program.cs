using CustomerSystem.Core.Interfaces;
using CustomerSystem.UI;
using CustomerSystem.UI.Views;

ICustomerRepository customerRepository = new InMemoryCustomerRepository();

IView[] views = [new AddCustomerView(),
                 new ListAllCustomersView(customerRepository),
                 new RemoveCustomerView(customerRepository)];

while (true)
{
    int choice = ArrowMenu.Show("Huvudmeny", views.TitlesToStringArray()); //En extension method, se EntensionMethods.cs

    if (choice == -1) break;

    views[choice].Show();
}