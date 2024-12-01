namespace HewTU;

public partial class CakeMenu : ContentPage
{
	public CakeMenu()
	{
		InitializeComponent();
	}

	private async void NavigateToChocolateCake(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.ChocolateCake());
    }
	private async void NavigateToBlueberryCheesePie(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.BlueberryCheesePie());
    }
	private async void NavigateToStrawberryShortCake(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.StrawberryShortCake());
    }
}