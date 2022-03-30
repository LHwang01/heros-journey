using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float horizontalMovement;
    [SerializeField] float verticalMovement;
    [SerializeField] float speed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(horizontalMovement, verticalMovement, 0f);

        transform.position += movement * Time.deltaTime * speed;
    }
}
