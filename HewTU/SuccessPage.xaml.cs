namespace HewTU;

public partial class SuccessPage : ContentPage
{
	public SuccessPage()
	{
		InitializeComponent();
	}

	private async void NavigateToStorePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderDetail());
    }
}