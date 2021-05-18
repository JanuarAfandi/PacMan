using System;
using System.Collections.Generic;
using UnityEngine;

namespace Foods
{
    public class FoodFactory : Singleton<FoodFactory>
    {
        public GameObject foodTarget, foodStune; //gameobject yang akan di instantiate 
        public ChooseFood[] chooseFoods; //array enum untuk menentukan pilihan user di inspector
    
        // public List<DataFood> ListFoods = new List<DataFood>();
        
        [HideInInspector]
        public int sizeTarget;

        //method untuk instantiate object food
        public void Create()
        {
            foreach (var cf in chooseFoods)
            { 
                switch (cf)
                {
                    case ChooseFood.FoodTarget:
                        Food ft = gameObject.AddComponent<FoodTarget>();
                        ft.Create(foodTarget);
                        sizeTarget++;
                        break;
                    case ChooseFood.FoodStune:
                        Food fs = gameObject.AddComponent<FoodStune>();
                        fs.Create(foodStune);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }

    //digunakan untuk memilih antara food target / stune berdasarkan input player di inspector
    public enum ChooseFood
    {
        FoodTarget,
        FoodStune
    }

    // [Serializable]
    // public struct DataFood
    // {
    //     public ChooseFood ChooseFood;
    //     public Vector3 Position;
    // }
}