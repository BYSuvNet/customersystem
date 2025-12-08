namespace CustomerSystem.UI.Views;

public interface IView
{
    string Title { get; }
    void Show();
}