using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pause : MonoBehaviour
{
    Image img;
    public Sprite playSprite;
    public Sprite pauseSprite;

    private void Start()
    {
        img = GetComponent<Image>();
    }

    public void OngamePaused()
    {
        if(GameManager.gameisPaused==false)
        {
            Time.timeScale = 0;
            img.sprite = playSprite;
            GameManager.gameisPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            img.sprite = pauseSprite;
            GameManager.gameisPaused = false;

        }
    }
}
