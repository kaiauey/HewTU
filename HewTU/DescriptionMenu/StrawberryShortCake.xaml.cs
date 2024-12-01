namespace HewTU.DescriptionMenu;

public partial class StrawberryShortCake : ContentPage
{
	public StrawberryShortCake()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}