using System.Collections;
using UnityEngine;

namespace Character
{
    //class 
    public class Ghost : Character<Ghost>
    {
        
        [HideInInspector] public static bool isStune = false;
        private bool _move = true;

        public override void Movement()
        {
            var position = Player.Instance.transform.position;
            if (_move)
            {
                if (position.x > transform.position.x && Mathf.Abs(position.x - transform.position.x) > 0.5f &&
                    !CheckCollider(Vector2.right))
                {
                    Move(Vector2.right);
                }
                else if (position.x < transform.position.x && Mathf.Abs(position.x - transform.position.x) > 1 &&
                         !CheckCollider(Vector2.left))
                {
                    Move(Vector2.left);
                }
                else if (position.y > transform.position.y && !CheckCollider(Vector2.up))
                {
                    Move(Vector2.up);
                }
                else if (position.y < transform.position.y && !CheckCollider(Vector2.down))
                {
                    Move(Vector2.down);
                }
                else
                {
                    Move(new Vector2());
                }
            }

            if(isStune)
                StartCoroutine(StuneActive());
        }

        private IEnumerator StuneActive()
        {
            _move = false;
            yield return new WaitForSeconds(5f);
            isStune = false;
            _move = true;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Data.Health--;
            }
        }
    }
}