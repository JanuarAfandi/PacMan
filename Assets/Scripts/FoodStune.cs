using System;
using UnityEngine;

public class FoodStune : Food
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Ghost.Instance.isStune = true;
            Destroy(gameObject);
        }
    }

    public override void Create(GameObject obj)
    {
        Instantiate(obj, transform.position + new Vector3(2,2,0), Quaternion.identity);
    }
}