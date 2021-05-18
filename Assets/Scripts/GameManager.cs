using System;
using Character;
using Firebase.Database;
using Foods;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    private DatabaseReference _reference;

    private void Awake()
    {
        Data.Health = 3;
        Data.Score = 0;
        Data.Name = "";
        FoodFactory.Instance.Create();
        TimeManagement.TimeInActive();
        
        Database.Get();
    }


    private void Update()
    {
        
        Player.Instance.Movement();

        Ghost.Instance.Movement();

        UI.Instance.EnterButtonClicked();
        UI.Instance.ShowUI();
        UI.Instance.ShowGameOver();
        UI.Instance.ShowGameWin();
        TimeManagement.Instance.SetTimer();

        if (GameWin.IsWin)
        {
            Database.Save(Data.Name, (int) (Data.Score * Data.Health * TimeManagement.Instance.Timer));
        }
    }
}