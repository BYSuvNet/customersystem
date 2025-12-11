namespace CustomerSystem.UI.Views;

public class SomethingView : IView
{
    public string Title => "Ett val";

    readonly string content = """
        Här kan vi göra vadsomhelst. Klassen tar inte in något i sin konstruktor,
        men skulle kunna ta emot vad som helst den behöver för att göra sin grej.
        Kanske en service, ett repository eller liknande.

        Tryck på valfri knapp för att gå tillbaka.
        """;

    public void Show()
    {
        Console.Clear();
        Console.WriteLine(content);
        Console.ReadKey(true);
    }
}