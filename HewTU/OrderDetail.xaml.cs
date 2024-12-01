namespace HewTU;

public partial class OrderDetail : ContentPage
{
	public OrderDetail()
	{
		InitializeComponent();
	}

	private async void NavigateToStorePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StorePage());
    }

}