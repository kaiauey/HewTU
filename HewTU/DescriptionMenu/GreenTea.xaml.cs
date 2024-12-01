namespace HewTU.DescriptionMenu;

public partial class GreenTea : ContentPage
{
	public GreenTea()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}