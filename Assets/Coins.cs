using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject Coin;
    float randY;
    public float minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CoinS", 1.0f, 2.0f);

    }

    // Update is called once per frame
    void Update()
    {
        //  CoinS();
        if (GameManager.gameOver == true)
        {
            CancelInvoke("CoinS");
        }
    }

    private void CoinS()
    {
        
            randY = Random.Range(minY, maxY);
        GameObject CoinRef = Instantiate(Coin);
        CoinRef.transform.position = new Vector2(transform.position.x, randY);
    }
    
}
