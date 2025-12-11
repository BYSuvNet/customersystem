using CustomerSystem.Core.Entities;

namespace CustomerSystem.UI.Views;

public class SubMenuView : IView
{
    public string Title => "-- En undermeny --";

    public void Show()
    {
        IView[] views = [new SomethingView(),
                 new SomethingElseView()];

        while (true)
        {
            int choice = ArrowMenu.Show("Gör ditt val:", views.TitlesToStringArray()); //En extension method, se EntensionMethods.cs

            if (choice == -1) break; //Break kommer att avbryta show och därmed återgå till den tidigare vyn

            views[choice].Show();
        }
    }
}