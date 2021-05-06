using System;
using UnityEngine;

public class FoodFactory : MonoBehaviour
{
    public GameObject[] foods;
    public ChooseFood[] chooseFoods;
    
    #region Singleton

    private static FoodFactory _foodFactory;

    public static FoodFactory Instance
    {
        get
        {
            if (_foodFactory == null)
            {
                _foodFactory = FindObjectOfType<FoodFactory>();
            }

            return _foodFactory;
        }
    }

    #endregion
    
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