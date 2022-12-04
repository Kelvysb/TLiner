using TLiner.Domain.Abstractions.Services;

namespace TLliner;

public partial class MainPage : ContentPage
{
    private int count = 0;

    private ITLinerService tLinerService;

    public MainPage(ITLinerService tLinerService)
    {
        this.tLinerService = tLinerService;
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}