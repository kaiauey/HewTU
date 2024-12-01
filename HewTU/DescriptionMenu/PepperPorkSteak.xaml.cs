namespace HewTU.DescriptionMenu;

public partial class PepperPorkSteak : ContentPage
{
	public PepperPorkSteak()
	{
		InitializeComponent();
	}

	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }
}