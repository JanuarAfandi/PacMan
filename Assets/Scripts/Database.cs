using System;
using System.Collections.Generic;
using System.Linq;
using Firebase.Database;
using UnityEngine;
using Random = UnityEngine.Random;

//4210191018 - M.Dwi Febrian

public class Database : Singleton<Database>
{
    private static DatabaseReference _reference;
    private static bool _upload;

    private void Start()
    {
        _upload = false;
    }
    
    //Save data to firebase database
    public static void Save(string name, int score)
    {
        var data = new Data
        {
            name = name,
            score = score
        };

        var json = JsonUtility.ToJson(data);
        var userId = name + Random.Range(0, 1000000);

        if (!_upload)
        {
            _reference = FirebaseDatabase.DefaultInstance.RootReference;
            _reference.Child("users").Child(userId).SetRawJsonValueAsync(json);
            _upload = true;
        }
    }

    //method untuk mengambil data dari database
    public static void Get()
    {
        _reference = FirebaseDatabase.DefaultInstance.GetReference("users");
        // _reference.ChildAdded += HandleChildAdded;
        _reference.GetValueAsync().ContinueWith(task =>
        {
            if (task.IsCompleted)
            {
                var listUser = new List<Data>();
                var result = task.Result;
                var childs = result.Children;
                foreach (var child in childs)
                {
                    var extractData = child.GetRawJsonValue();
                    var data = JsonUtility.FromJson<Data>(extractData);
                    listUser.Add(data);
                }

                var listSort = listUser.OrderByDescending(list => list.score).ToList();
                foreach (var list in listSort)
                {
                    print(list.name);
                    print(list.score);
                }
                
            }
        });
    }
    
    //Model untuk menyimpan data dari database
    [Serializable]
    private struct Data
    {
        public string name;
        public int score;
    }
}