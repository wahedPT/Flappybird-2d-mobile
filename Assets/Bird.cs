using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    int angle;
    int minAngle = -10  ;
    int maxAngle=5;
    bool touchedGround;
    public GameManager gameManager;
    Animator anim;
   
    
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&GameManager.gameOver==false&& GameManager.gameisPaused==false)
        {
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        BirdAngle();

        

    }

    private void BirdAngle()
    {
        if (rb.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 5;

            }
        }
        else if (rb.velocity.y < 0)
        {
            if (angle >= minAngle)
            {
                angle = angle - 5;

            }
        }
        if (touchedGround == false)
        {
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Column")
        {
            Score.ScoreValue += 1;
        }
        else if (collision.gameObject.tag == "Pipe")
        {
            Debug.Log("GameOver!!");
            gameManager.GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(GameManager.gameOver==false)
            {
                //game over
                gameManager.GameOver();
                BirdDied();
            }
            else
            {
                BirdDied();
            }
        }
    }

    void BirdDied()
    {
        touchedGround = true;
        anim.enabled = false;
    }
}
