using UnityEngine;

namespace Character
{
    //abstract class Character yang diturunkan kepada class player dan ghost karena mempunyai beberapa fungsi yang sama 
    public abstract class Character<T> : Singleton<Character<T>>
    {
        [Header("Movement")]
        public float speed;
        public float distance = 1f;
        public LayerMask board;
        
        //method untuk mengecek collider
        protected bool CheckCollider(Vector2 position) => Physics2D.Raycast(
            transform.position, 
            position, 
            distance, 
            board);
        
        //method untuk movement
        protected void Move(Vector2 turn) => transform.Translate( turn * (Time.deltaTime * speed) );
        
        //method untuk input movement
        public abstract void Movement();
    }
}
