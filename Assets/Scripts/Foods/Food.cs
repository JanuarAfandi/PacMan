using UnityEngine;

namespace Foods
{
    //abstract class yang diturunkan pada class foodTarget dan foodStune untuk instantiate object
    public abstract class Food : MonoBehaviour
    {
        public abstract void Create(GameObject obj);
    }
}