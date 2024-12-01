namespace HewTU;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new StorePage());
    }
}