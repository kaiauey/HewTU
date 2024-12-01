using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using HewTU.Models;
using HewTU.Services;

namespace HewTU.MVVM;

public class MenuPageViewModel
{
    private readonly FirestoreService _firestoreService;
    public ObservableCollection<Menu> MenuItems { get; set; } = new ObservableCollection<Menu>();

    // Constructor ที่รับ storeId
    public MenuPageViewModel(string storeId)
    {
        _firestoreService = new FirestoreService();
        LoadMenuAsync(storeId);
    }

    private async Task LoadMenuAsync(string storeId)
    {
        var menuItems = await _firestoreService.GetMenuAsync(storeId);
        MenuItems.Clear();
        foreach (var menu in menuItems)
        {
            MenuItems.Add(menu);
        }
    }
}