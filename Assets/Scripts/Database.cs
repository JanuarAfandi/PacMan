using System;
using System.Collections.Generic;
using System.Linq;
using Firebase.Database;
using UnityEngine;
using Random = UnityEngine.Random;

public class Database : Singleton<Database>
{
    private static DatabaseReference _reference;
    private static bool _upload;
    private static List<Data> datas = new List<Data>();
    
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
    public static List<Data> Get()
    {
        _reference = FirebaseDatabase.DefaultInstance.GetReference("users");
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
                    var data = new Data()
                    {
                        name = list.name,
                        score = list.score
                    };
                  
                    datas.Add(data);
                    
                }
            }
        });
        
        return datas;
    }
    
    //Model untuk menyimpan data dari database
    [Serializable]
    public struct Data
    {
        public string name;
        public int score;
    }
}