using TLiner.Domain.Abstractions.Services;

namespace TLliner.Pages;

public partial class ProjectSelection : ContentPage
{
    private ITLinerService tLinerService;

    public ProjectSelection(ITLinerService tLinerService)
    {
        this.tLinerService = tLinerService;
        InitializeComponent();
    }

    private void BtnNewProject_Clicked(object sender, EventArgs e)
    {
    }

    private void TxtSearch_Completed(object sender, EventArgs e)
    {
    }
}