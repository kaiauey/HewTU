namespace HewTU.DescriptionMenu;

public partial class Thaitea : ContentPage
{
	public Thaitea()
	{
		InitializeComponent();
	}

	private void OnToppingSelected(object sender, EventArgs e)
	{
		var picker = (Picker)sender;
		string selectedTopping = picker.SelectedItem.ToString();
		// ใช้ selectedTopping ในการคำนวณหรือแสดงผล
	}
	private async void NavigateToOrderSummary(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OrderSummaryPage());
    }

}