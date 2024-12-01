namespace HewTU.DescriptionMenu;

public partial class MilkTea : ContentPage
{
	public MilkTea()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}