using Character;
using UnityEngine;

namespace Foods
{
    public class FoodStune : MonoBehaviour, IFactory
    {
        //method untuk mengecek collider foodStune
        private void OnTriggerEnter2D(Collider2D other)
        {
            //jika food bertabrakan dg player, maka aktifkan stune pada ghost/enemy dan destroy this object
            if (!other.gameObject.CompareTag(Constant.Player)) return;
            
            Ghost.isStune = true;
            Destroy(gameObject);
        }

        
        //method untuk instantiate object foodStune
        public void Create(GameObject obj)
        {
            obj.SetActive(true);
        }
    }
}