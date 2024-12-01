using System;
using Google.Cloud.Firestore;

namespace HewTU.Models;

[FirestoreData]
public class Store
{
    [FirestoreProperty]
    public string Id { get; set; }

    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public string Image { get; set; }
}