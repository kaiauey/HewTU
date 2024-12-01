namespace HewTU.DescriptionMenu;

public partial class ChocolateCake : ContentPage
{
	public ChocolateCake()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}