namespace HewTU.DescriptionMenu;

public partial class Malatang : ContentPage
{
	public Malatang()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}