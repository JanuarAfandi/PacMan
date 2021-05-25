using Character;
using Foods;
using UnityEngine;

//4210191018 - M.Dwi Febrian

public class GameManager : MonoBehaviour
{
    //Method yang dijalankan sekali di awal scene 
    private void Start()
    {
        //set data player
        Data.Health = 3;
        Data.Score = 0;
        Data.Name = "";
        
        //instantiate object food
        Factory.Instance.Create();
        TimeManagement.TimeInActive();
        
        Database.Get();
    }

    //Method yang dijalankan terus menerus disetiap frame 
    private void Update()
    {
        //Player
        Player.Instance.Movement();

        //Ghost
        Ghost.Instance.Movement();

        //UI
        UI.Instance.EnterButtonClicked();
        UI.Instance.ShowUIPlayer();
        UI.Instance.ShowGameOver();
        UI.Instance.ShowGameWin();
        
        //Time
        TimeManagement.Instance.SetTimer();

        //Save to Database
        if (GameWin.IsWin)
        {
            Database.Save(Data.Name, (int) (Data.Score * Data.Health * TimeManagement.Instance.Timer));
        }
    }
}