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
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
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
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
