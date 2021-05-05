using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Data.Score++;
            Destroy(gameObject);
        }
    }
}
