using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [Header("Movement")]
    public float speed;

    public float distance = 1f;
    public LayerMask board;
    
    protected bool CheckCollider(Vector2 position) => Physics2D.Raycast(
        transform.position, 
        position, 
        distance, 
        board);
   
    protected void Move(Vector2 turn) => transform.Translate( turn * (Time.deltaTime * speed) );
    public abstract void Movement();
}
