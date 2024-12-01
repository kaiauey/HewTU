using System;
using Google.Cloud.Firestore;

namespace HewTU.Models;

[FirestoreData]
public class Menu
{
    [FirestoreProperty]
    public string Id { get; set; }
    [FirestoreProperty]
    public string MenuName { get; set; }

    [FirestoreProperty]
    public string Price { get; set; }
}
