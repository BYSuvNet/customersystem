using CustomerSystem.Core.Entities;

namespace CustomerSystem.UI.Views;

public class AddCustomerView : IView
{
    public string Title { get => "Visa alla kunder"; }

    public void Show()
    {
        Console.WriteLine("-- LÄGG TILL KUND --\n");

        Console.Write("Förnamn: ");
        string? firstname = Console.ReadLine();

        Console.Write("Efternamn: ");
        string? lastname = Console.ReadLine();

        Name name = new Name(firstname, lastname);

        Console.WriteLine("Tryck på valfri knapp för att fortsätta");
        Console.ReadLine();
    }
}