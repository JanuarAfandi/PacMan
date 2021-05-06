using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        FoodFactory.Instance.Create();
    }
    
    void Update()
    {
        Player.Instance.Movement();
        Ghost.Instance.Movement();
    }
}
