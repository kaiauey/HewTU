namespace HewTU.DescriptionMenu;

public partial class SalmonSteak : ContentPage
{
	public SalmonSteak()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}