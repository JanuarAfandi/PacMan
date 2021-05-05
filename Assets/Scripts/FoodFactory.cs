using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFactory : MonoBehaviour, IEntity
{
    [SerializeField] private GameObject food;
    
    #region Singleton
    private static FoodFactory _foodFactory;
    public static FoodFactory Instance
    {
        get
        {
            if (_foodFactory == null)
            {
                _foodFactory = GameObject.FindObjectOfType<FoodFactory>();
            }

            return _foodFactory;
        }
    }
    #endregion
    
    public void Create()
    {
        Instantiate(food, transform.position, Quaternion.identity);
    }

}
