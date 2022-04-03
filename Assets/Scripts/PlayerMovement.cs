using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public Animator animator;
    public ScoreKeeper scoreKeeper;

    [Header("Movement Settings")]
    [SerializeField] float moveSpeed = 7f;
    [SerializeField] float jumpPower = 8f;

    [Header("Bools")]
    [SerializeField] bool isGrounded = false;

    bool isFacingRight = true;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal") * moveSpeed));

        transform.position += move * Time.deltaTime * moveSpeed;
        Jump();

        if (Input.GetAxis("Horizontal") < 0 && isFacingRight || Input.GetAxis("Horizontal") > 0 && !isFacingRight)
        {
            Flip();
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rigidbody2d.AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;

        if (other.gameObject.tag == "Collectible") {
            scoreKeeper.increaseScore();
            Destroy(other.gameObject);
        }
    }

    void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }
    
    void OnTriggerEnter2d(Collider2D other)
    {
        
    }
}
