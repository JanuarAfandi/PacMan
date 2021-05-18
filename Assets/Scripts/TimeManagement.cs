using System;
using UnityEngine;

//class yang digunakan untuk menghandle waktu pada game
public class TimeManagement : Singleton<TimeManagement>
{
    //batas waktu yang diberikan pada player untuk menyelesaikan game sebelum waktu habis 
   public float timer;
   
   public float Minutes { get; private set; }

    public float Seconds { get; private set; }
    
    // method yang digunakan untuk melanjutkan waktu/resume game
    public static void TimeActive()
    {
        Time.timeScale = 1f;
    }

    //method yang digunakan untuk mengehentikan waktu/pause game
    public static void TimeInActive()
    {
        Time.timeScale = 0f;
    }

    //method untuk melakukan set timer
    public void SetTimer()
    {
        //Jika game belum berakhir kurangi timer
        if(!GameWin.IsWin || !GameOver.IsGameOver)
            timer -= Time.deltaTime;
      
        //convert timer to minutes & seconds
        Minutes = Mathf.FloorToInt(timer / 60);
        Seconds = Mathf.FloorToInt(timer % 60);
    }

    //return variable timer
    public float Timer => timer;
}
