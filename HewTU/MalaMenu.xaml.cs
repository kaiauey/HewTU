namespace HewTU;

public partial class MalaMenu : ContentPage
{
	public MalaMenu()
	{
		InitializeComponent();
	}

	private async void NavigateToMalatang(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.Malatang());
    }
	private async void NavigateToMalaStick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.MalaStick());
    }
	private async void NavigateToMalaTomyum(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DescriptionMenu.MalaTomyum());
    }
}