using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public GameObject GameOverPanel;
    public GameObject ScoreOnj;
    public GameObject pauseobj;


    //game states
    public static bool gameOver;
    public static bool gamehasStarted;
    public static bool gameisPaused;


    private void Awake()
    {

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
    }
    void Start()
    {
        gameOver = false;
        gamehasStarted = false;
        gameisPaused = false;
    }
    public void GameOver()
    {
        gameOver = true;
        GameOverPanel.SetActive(true);
        ScoreOnj.SetActive(false);
        pauseobj.SetActive(false);
        //gameisPaused = false;
    }

    public void onokButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    void Update()
    {
        
    }
}
