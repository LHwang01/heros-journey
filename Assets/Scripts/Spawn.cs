using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    Vector2[] positions = new Vector2[] {
        new Vector2(-8.4F, -1.2F),
        new Vector2(8.4F, -1.2F),
        new Vector2(8.4F, 0.8F),
        new Vector2(-8.4F, 0.8F),
        new Vector2(8.4F, -3.6F),
        new Vector2(-8.4F, -3.6F),
    };



    [SerializeField] float delayInterval;

    [SerializeField] GameObject obj;

    void Start()
    {
        InvokeRepeating("SpawnRandom", 1, delayInterval);
    }


    void Update()
    {
        
    }

    void SpawnRandom()
    {
        Vector2 randomPosition = positions[Random.Range(0, positions.Length)];

        if ((Physics2D.OverlapCircle(randomPosition, .3F)) == null) {
            Instantiate(obj, randomPosition, Quaternion.identity);
        } else {
            Destroy(Physics2D.OverlapCircle(randomPosition, .3F).gameObject);
            Instantiate(obj, randomPosition, Quaternion.identity);
        }

    }
}
