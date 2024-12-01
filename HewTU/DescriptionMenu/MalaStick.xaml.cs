namespace HewTU.DescriptionMenu;

public partial class MalaStick : ContentPage
{
	public MalaStick()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}