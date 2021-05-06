using UnityEngine;

public class FoodTarget : Food
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
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
