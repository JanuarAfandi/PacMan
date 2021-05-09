using PacMan.Character;
using PacMan.Foods;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        Data.Health = 3;
        FoodFactory.Instance.Create();
        TimeManagement.TimeInActive();
    }

    private void Update()
    {
        
        Player.Instance.Movement();
        
        Ghost.Instance.Movement();
        
        UI.Instance.EnterButtonClicked();
        UI.Instance.ShowUI();
        UI.Instance.ShowGameOver();
        
        TimeManagement.Instance.SetTimer();
    }
}
