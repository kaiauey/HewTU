namespace HewTU.DescriptionMenu;

public partial class CreamCornPorkchop : ContentPage
{
	public CreamCornPorkchop()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}