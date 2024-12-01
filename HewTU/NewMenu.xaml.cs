namespace HewTU;

public partial class NewMenu : ContentPage
{
	public NewMenu()
	{
		InitializeComponent();
	}

	private async void NavigateToThaiTea(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DescriptionMenu.Thaitea());
	}
	private async void NavigateToMilkTea(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DescriptionMenu.MilkTea());
	}
	private async void NavigateToGreenTea(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DescriptionMenu.GreenTea());
	}
}