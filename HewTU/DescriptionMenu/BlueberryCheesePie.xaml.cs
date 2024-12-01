namespace HewTU.DescriptionMenu;

public partial class BlueberryCheesePie : ContentPage
{
	public BlueberryCheesePie()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}