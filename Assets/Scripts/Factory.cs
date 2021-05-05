using System;
using UnityEngine;

public class Factory : MonoBehaviour {
    
    private readonly Object _obj;
    public Factory(Object obj)
    {
        _obj = obj;
    }
    
    public void Create()
    {
        switch (_obj)
        {
            case Object.Food:
                FoodFactory.Instance.Create();
            break;
            case Object.Ghost:
                  break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}

public enum Object
{
    Ghost,
    Food
}
