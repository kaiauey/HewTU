using System;
using Google.Cloud.Firestore;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using HewTU.Models;

namespace HewTU.Services;

public class FirestoreService
{
    private FirestoreDb _firestoreDb;

    public FirestoreService()
    {
        // กำหนด Firebase Firestore (แทนด้วย Firebase Project ID ของคุณ)
        this.SetupFireStore();
    }

    private async Task SetupFireStore()
    {
        if (_firestoreDb == null)
        {
            var stream = await FileSystem.OpenAppPackageFileAsync("app2024-243ce-firebase-adminsdk-f5r6q-c8defe7299.json");
            var reader = new StreamReader(stream);
            var contents = reader.ReadToEnd();
            this._firestoreDb = new FirestoreDbBuilder
            {
                ProjectId = "app2024-243ce",

                JsonCredentials = contents
            }.Build();
        }

    }


    // ดึงข้อมูลร้านค้าจาก Collection "Stores"
    public async Task<ObservableCollection<Store>> GetStoresAsync()
    {
        try
        {
            var stores = new ObservableCollection<Store>();
            var querySnapshot = await _firestoreDb.Collection("Stores").GetSnapshotAsync();

            foreach (var document in querySnapshot.Documents)
            {
                if (document.Exists)
                {
                    var store = document.ConvertTo<Store>();
                    store.Id = document.Id; 
                    stores.Add(store);
                }
            }
            return stores;
        }
        catch(Exception ex)
        {

            throw;
        }
    }
    // ดึงเมนูจาก Collection "menu" ของร้านค้า
    public async Task<ObservableCollection<Menu>> GetMenuAsync(string storeId)
    {
        var menuItems = new ObservableCollection<Menu>();
        var querySnapshot = await _firestoreDb.Collection("Stores").Document(storeId).Collection("menu").GetSnapshotAsync();

        foreach (var document in querySnapshot.Documents)
        {
            if (document.Exists)
            {
                var menu = document.ConvertTo<Menu>();
                menu.Id = document.Id; 
                menuItems.Add(menu);
            }
        }
        return menuItems;
    }
}

//app2024-243ce-firebase-adminsdk-f5r6q-ebfc85a96a
//$env:GOOGLE_APPLICATION_CREDENTIALS="C:app2024-243ce-firebase-adminsdk-f5r6q-ebfc85a96a.json"
