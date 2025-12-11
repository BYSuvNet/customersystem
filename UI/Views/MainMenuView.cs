using CustomerSystem.Core.Entities;
using CustomerSystem.Core.Interfaces;

namespace CustomerSystem.UI.Views;

public class MainMenuView(ICustomerRepository customerRepository) : IView
{
    public string Title => "Ett val med undermeny";

    readonly IView[] views = [new AddCustomerView(),
                new ListAllCustomersView(customerRepository),
                new RemoveCustomerView(customerRepository),
                new SubMenuView()];

    public void Show()
    {
        while (true)
        {
            int choice = ArrowMenu.Show("Huvudmeny", views.TitlesToStringArray(), "Avsluta"); //En extension method, se EntensionMethods.cs

            if (choice == -1) break;

            views[choice].Show();
        }
    }
}