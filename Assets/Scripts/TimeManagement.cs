using System;
using UnityEngine;

//class yang digunakan untuk menghandle waktu pada game
public class TimeManagement : Singleton<TimeManagement>
{
   public float timer;

   public float Minutes { get; private set; }

    public float Seconds { get; private set; }
    
    // ReSharper restore Unity.ExpensiveCode
    public static void TimeActive()
    {
        Time.timeScale = 1f;
    }

    public static void TimeInActive()
    {
        Time.timeScale = 0f;
    }

    public void SetTimer()
    {
        if(!GameWin.IsWin)
            timer -= Time.deltaTime;
      
        Minutes = Mathf.FloorToInt(timer / 60);
        Seconds = Mathf.FloorToInt(timer % 60);
    }

    public float Timer => timer;
}
