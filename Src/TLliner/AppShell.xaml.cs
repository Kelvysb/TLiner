namespace TLliner;

public partial class AppShell : Shell
{
    public AppShell(MainPage mainPage)
    {
        InitializeComponent();
        ShellContent.Content = mainPage;
    }
}