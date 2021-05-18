using System;
using Character;
using Foods;
using UnityEngine;


public class GameWin : Singleton<GameWin>
{
    public static bool IsWin => (Data.Score == FoodFactory.Instance.sizeTarget);
}