using CustomerSystem.Core.Interfaces;
using CustomerSystem.UI;
using CustomerSystem.UI.Views;

internal class Program
{
    private static void Main(string[] args)
    {
        ICustomerRepository customerRepository = new InMemoryCustomerRepository();

        IView[] views = [new AddCustomerView(),
                 new ListAllCustomersView(customerRepository),
                 new RemoveCustomerView(customerRepository),
                 new SubMenuView()];

        while (true)
        {
            int choice = ArrowMenu.Show("Huvudmeny", views.TitlesToStringArray(), "Avsluta"); //En extension method, se EntensionMethods.cs

            if (choice == -1) break;

            views[choice].Show();
        }
    }
}