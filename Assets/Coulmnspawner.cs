using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coulmnspawner : MonoBehaviour
{
    public GameObject ColPrefab;
    public float minY, maxY;
    float randY;
    float timer;
    public float maxTime;
    void Start()
    {
        cSpawn();
        //InvokeRepeating("cSpawn", 2.0f, 5.0f);

    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            cSpawn();
            timer = 0;
        }
    }
    void cSpawn()
    {
        randY = Random.Range(minY, maxY);
        GameObject tempcol= Instantiate(ColPrefab);
        tempcol.transform.position = new Vector2(transform.position.x, randY);
    }
}
