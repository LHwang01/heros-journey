using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public Animator animator;
    public ScoreKeeper scoreKeeper;
    public Health health;

    Animator anim;
    [SerializeField] AudioSource sword;

    [Header("Movement Settings")]
    [SerializeField] float moveSpeed = 7f;
    [SerializeField] float jumpPower = 8f;

    [Header("Bools")]
    [SerializeField] bool isGrounded = false;

    bool isFacingRight = true;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
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
        } else if (other.gameObject.tag == "Enemy") {
            sword.Play();
            Destroy(other.gameObject);

            int currentHealth = health.getHealth();
            health.setHealth(currentHealth - 1);

            if (currentHealth - 1 == 0) {
                moveSpeed = 0;
                jumpPower = 0;

                anim.Play("Lancelot Capture Animation");
                Destroy(this.gameObject, 1.5f);

                StartCoroutine(ChooseEnding(scoreKeeper.getScore()));
            }
        }
    }

    void Flip()
    {
        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;
    }
    
    IEnumerator ChooseEnding(int endingScore) {
        yield return new WaitForSeconds(1);

        if (endingScore < 100) {
            SceneManager.LoadScene("0. Game Over");
        } else if (endingScore >= 100 && endingScore <= 500) {
            SceneManager.LoadScene("1. Knighthood Ending");
        } else if (endingScore >= 510 && endingScore <= 1000) {
            SceneManager.LoadScene("2. Senior Knight Ending");
        } else if (endingScore > 1100 && endingScore <= 2000) {
            SceneManager.LoadScene("3. Elder Knight Ending");
        } else {
            SceneManager.LoadScene("4. Next Siegfried Ending 1");
        }
    }
}
