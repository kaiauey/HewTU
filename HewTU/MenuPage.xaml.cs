using System;
using System.Collections.ObjectModel;
using HewTU.DescriptionMenu;
using HewTU.MVVM;
using HewTU.Services;
using Microsoft.Maui.Controls;

namespace HewTU;

public partial class MenuPage : ContentPage
{
    private FirestoreService _firestoreService;
    private string storeId;
    public MenuPage(string storeId)
    {
        this.storeId = storeId;
        InitializeComponent();
        this.LoadData();
        //BindingContext = new MenuPageViewModel(storeId);
    }

    private async void LoadData()
    {
         _firestoreService = new FirestoreService();
        var menues = await _firestoreService.GetMenuAsync(this.storeId);
        CollectionViewMenu.ItemsSource = menues;
    }
    private async void NavigateToThaiTea(object sender, EventArgs e)
	{
        var button = sender as ImageButton;

    if (button != null)
    {
        await button.ScaleTo(1.2, 100); // ขยายปุ่มเล็กน้อย
        await button.ScaleTo(1, 100);   // กลับคืนขนาดเดิม
    }
		await Navigation.PushAsync(new DescriptionMenu.Thaitea());
	}
}
