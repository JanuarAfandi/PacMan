using Character;
using UnityEngine;

//4210191018 - M.Dwi Febrian
namespace Foods
{
    public class FoodStune : Food
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
        public override void Create(GameObject obj)
        {
            Instantiate(obj, transform.position + new Vector3(2,2,0), Quaternion.identity);
        }
    }
}