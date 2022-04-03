using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChest : MonoBehaviour
{
    Vector2[] positions = new Vector2[] {
        new Vector2(-8.4F, -1.2F),
        new Vector2(8.4F, -1.2F),
        new Vector2(8.4F, 0.8F),
        new Vector2(-8.4F, 0.8F),
        new Vector2(8.4F, -3.6F),
        new Vector2(-8.4F, -3.6F),
    };



    public float delayInterval = 5;

    [SerializeField] GameObject chest;

    void Start()
    {
        InvokeRepeating("SpawnRandChest", 1, delayInterval);
    }


    void Update()
    {
        
    }

    void SpawnRandChest()
    {
        Vector2 randomPosition = positions[Random.Range(0, positions.Length)];

        if ((Physics2D.OverlapCircle(randomPosition, .3F)) == null) {
            Instantiate(chest, randomPosition, Quaternion.identity);
        }

    }
}
