namespace HewTU;

public partial class SteakMenu : ContentPage
{
	public SteakMenu()
	{
		InitializeComponent();
	}

	private async void NavigateToCreamCornPorkchop(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.CreamCornPorkchop());
    }
	private async void NavigateToPepperPorkSteak(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.PepperPorkSteak());
    }
	private async void NavigateToSalmonSteak(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.SalmonSteak());
    }
}