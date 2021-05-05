using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Factory _factory;
    public Factory f;
    void Start()
    {
        _factory = new Factory(Object.Food);
        _factory.Create();
        _factory = new Factory(Object.Food);
        _factory.Create();
        
    }
    
    void Update()
    {
        Player.Instance.Movement();
        Ghost.Instance.Movement();
    }
}
