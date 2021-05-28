using System;
using System.Collections.Generic;
using Character;
using UnityEngine;

namespace Foods
{
    public class Factory : Singleton<Factory>
    {
        public List<DataObject> listObject = new List<DataObject>();
        
        [HideInInspector]
        public int sizeTarget;

        //method untuk menambahkan component script food stune/ food target / ghost pada gameobject
        public void Create()
        {
            foreach (var listObj in listObject)
            { 
                switch (listObj.choose)
                {
                    case Choose.FoodTarget:
                        IFactory ft = listObj.obj.AddComponent<FoodTarget>();
                        ft.Create(listObj.obj);
                        sizeTarget++;
                        break;
                    case Choose.FoodStune:
                        IFactory fs = listObj.obj.AddComponent<FoodStune>();
                        fs.Create(listObj.obj);
                        break;
                    case Choose.Ghost:
                        IFactory gh = listObj.obj.AddComponent<Ghost>();
                        gh.Create(listObj.obj);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }

    //digunakan untuk memilih antara food target / stune berdasarkan input player di inspector
    public enum Choose
    {
        FoodTarget,
        FoodStune,
        Ghost
    }

    //model untuk meyimpan gameobject food/ghost dan enum choose
    [Serializable]
    public struct DataObject
    {
        public GameObject obj;
        public Choose choose;
    }
}
