using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float Radius;
    private GameObject stick;



    void Update()
    {
    }
    void SpawnObjectAtRandom()
    {
        Vector2 randomP = Random.insideUnitSphere * Radius;
        while (randomP.y <= 0)
        {
            randomP = Random.insideUnitSphere * Radius;
        }
        if (stick == null)
        {
            stick = Instantiate(ItemPrefab, randomP, Quaternion.identity);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SpawnObjectAtRandom();
        }
    }
}