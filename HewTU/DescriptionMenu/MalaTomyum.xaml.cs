namespace HewTU.DescriptionMenu;

public partial class MalaTomyum : ContentPage
{
	public MalaTomyum()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}