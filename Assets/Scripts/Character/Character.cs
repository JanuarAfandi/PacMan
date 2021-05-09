using UnityEngine;

namespace PacMan.Character
{
    public abstract class Character<T> : Singleton<Character<T>>
    {
        [Header("Movement")]
        public float speed;
        public float distance = 1f;
        public LayerMask board;

        /// <summary>
        ///   <para>Returns true if this object collide with other object, and false if doesn't</para>
        /// </summary>
        protected bool CheckCollider(Vector2 position) => Physics2D.Raycast(
            transform.position, 
            position, 
            distance, 
            board);
   
        /// <summary>
        ///   <para>Move object</para>
        /// </summary>
        /// <param name="turn">Direction move</param>
        protected void Move(Vector2 turn) => transform.Translate( turn * (Time.deltaTime * speed) );
        public abstract void Movement();
    }
}
