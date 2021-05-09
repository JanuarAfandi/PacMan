using System;
using System.Collections.Generic;
using PacMan.Foods;
using UnityEngine;

namespace PacMan.Foods
{
    public class FoodFactory : Singleton<FoodFactory>
    {
        public GameObject[] foods;
        public ChooseFood[] chooseFoods;
    
        public List<DataFood> ListFoods = new List<DataFood>();

        public void Create()
        {
            foreach (var cf in chooseFoods)
            { 
                switch (cf)
                {
                    case ChooseFood.FoodTarget:
                        Food ft = gameObject.AddComponent<FoodTarget>();
                        ft.Create(foods[0]);
                        break;
                    case ChooseFood.FoodStune:
                        Food fs = gameObject.AddComponent<FoodStune>();
                        fs.Create(foods[1]);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }

    public enum ChooseFood
    {
        FoodTarget,
        FoodStune
    }

    [System.Serializable]
    public struct DataFood
    {
        public ChooseFood ChooseFood;
        public Vector3 Position;
    }
}