using System;
using Character;
using Foods;
using UnityEngine;


public class GameWin : Singleton<GameWin>
{
    //method untuk mengecek jika foodtarget sudah terpenuhi maka player win
    public static bool IsWin => (Data.Score == FoodFactory.Instance.sizeTarget);
}