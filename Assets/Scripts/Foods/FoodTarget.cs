using Character;
using UnityEngine;

//4210191018 - M.Dwi Febrian
namespace Foods
{
    public class FoodTarget : MonoBehaviour,IFactory
    {
        //method untuk mengecek collider foodTarget
        private void OnTriggerEnter2D(Collider2D other)
        {
            //jika food bertabrakan dg player, maka increment score dan destroy this object
            if (other.gameObject.CompareTag(Constant.Player))
            {
                Data.Score++;
                Destroy(gameObject);
            }
        }
        
        //method untuk instantiate object foodTarget
        public void Create(GameObject obj)
        {
            obj.SetActive(true);
        }
    }
}
