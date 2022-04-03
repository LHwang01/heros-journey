using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    bool isFacingRight;

    void Start()
    {
        if (this.transform.position.x > 7) {
            isFacingRight = false;
            transform.Rotate(0, 180, 0);
        } else {
            isFacingRight = true;
        }
    }

    void Update()
    {
        if (isFacingRight) {
            transform.position += new Vector3(.01F, 0, 0);
        } else {
            transform.position += new Vector3(-.01F, 0, 0);
        }

        if (this.transform.position.x > 9 || this.transform.position.x < -9) {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Collectible") {
            Destroy(other.gameObject);
        }
    }
}
