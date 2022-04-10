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

        if (Time.timeScale != 0) {
            if (isFacingRight) {
                transform.position += new Vector3(5F, 0, 0) * Time.deltaTime;
            } else {
                transform.position += new Vector3(-5F, 0, 0) * Time.deltaTime;
            }
        }

        if (this.transform.position.x > 9 || this.transform.position.x < -9) {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Collectible") {
            Destroy(other.gameObject);
        } else if (other.gameObject.tag == "Enemy") {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
