namespace CustomerSystem.UI.Views;

public class SomethingElseView : IView
{
    public string Title => "Ett annat val";

    readonly string content = """
        Här kan vi göra något annat en i den första vyn.

        Tryck på valfri knapp för att gå tillbaka.
        """;

    public void Show()
    {
        Console.Clear();
        Console.WriteLine(content);
        Console.ReadKey(true);
    }
}