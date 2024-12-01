using HewTU.Models;
using HewTU.MVVM;
using System;
using Microsoft.Maui.Controls;
using HewTU.Services;

namespace HewTU;

public partial class StorePage : ContentPage
{
	 private FirestoreService _firestoreService;
    public StorePage()
    {
        InitializeComponent();

        //BindingContext = new StorePageViewModel();
        this.LoadData();
    }

    private async Task LoadData()
    {
        _firestoreService = new FirestoreService();
        var stores = await _firestoreService.GetStoresAsync();
        CollectionViewStores.ItemsSource = stores;

    }

    private async void NavigateToMenu(object sender, EventArgs e)
    {
        if (sender is ImageButton button && button.CommandParameter is string id)
        {
            // Use the ID to perform the desired action, e.g., navigate to another page
            Console.WriteLine($"Navigating to menu with ID: {id}");

            await Navigation.PushAsync(new MenuPage(id));
        }

    }

    // Event handler for TextChanged
    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        // Logic ที่คุณต้องการใส่เมื่อ Text ถูกเปลี่ยน
        Console.WriteLine($"Text changed to: {e.NewTextValue}");
    }
    private async void NavigateToNewMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewMenu());
    }
    private async void NavigateToSteakMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SteakMenu());
    }
    private async void NavigateToMalaMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MalaMenu());
    }
    private async void NavigateToCakeMenu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CakeMenu());
    }

}