using TLiner.Domain.Abstractions.Services;
using TLliner.Pages;

namespace TLliner;

public partial class App : Application
{
    private readonly ITLinerService tLinerService;

    public App(ITLinerService tLinerService)
    {
        InitializeComponent();
        this.tLinerService = tLinerService;
        MainPage = new NavigationPage(new ProjectSelection(tLinerService));
    }
}