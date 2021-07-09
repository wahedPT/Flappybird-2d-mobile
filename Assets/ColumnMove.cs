using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -0.8)
        {
            Destroy(gameObject);
        }
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Score.ScoreValue += 1;
            Destroy(gameObject);
        }
    }
}
