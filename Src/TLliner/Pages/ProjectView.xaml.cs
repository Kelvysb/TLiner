using TLiner.Domain.Abstractions.Services;

namespace TLliner.Pages;

public partial class ProjectView : ContentPage
{
    private readonly ITLinerService tLinerService;

    public ProjectView(ITLinerService tLinerService)
    {
        this.tLinerService = tLinerService;
        InitializeComponent();
    }
}