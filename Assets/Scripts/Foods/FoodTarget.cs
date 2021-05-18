using Character;
using UnityEngine;

namespace Foods
{
    public class FoodTarget : Food
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag(Constant.Player))
            {
                Data.Score++;
                Destroy(gameObject);
            }
        }

        public override void Create(GameObject obj)
        {
            Instantiate(obj, transform.position, Quaternion.identity);
        }
    }
}
