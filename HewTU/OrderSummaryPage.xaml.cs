namespace HewTU;

public partial class OrderSummaryPage : ContentPage
{
	public OrderSummaryPage()
	{
		InitializeComponent();
	}

	private async void NavigateToSuccessPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SuccessPage());
    }
}
