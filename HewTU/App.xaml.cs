namespace HewTU;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		//MainPage = new RegisterPage();
		//MainPage = new StorePage();
		//MainPage = new OrderSummaryPage();
		//MainPage = new SuccessPage();
		//MainPage = new MenuPage();
		//MainPage = new OrderDetail();
		MainPage = new NavigationPage(new RegisterPage());
	}
}
