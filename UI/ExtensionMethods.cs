namespace CustomerSystem.UI.Views;

// Istället för att lägga denna kod i meny-koden så gör jag det som en extensionmetohod som kan köras på listor med IView.
// Detta för att hålla meny-koden renare och mer fokuserad på just menyn, och inte blanda in IViews.
// För att detta ska funka var jag dock tvungen att lägga in en titel i IView interfacet, propertyn Title.

public static class ExtensionMethods
{
    public static string[] TitlesToStringArray(this IView[] views)
    {
        string[] titles = new string[views.Length];
        for (int i = 0; i < views.Length; i++)
        {
            titles[i] = views[i].Title;
        }
        return titles;

        //Samma med LINQ:
        //return views.Select(v => v.Title).ToArray();
    }
}