using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class GameOver : MonoBehaviour
{
    public static bool isPlayerDead = false;
    Text gameOver;

    void Start()
    {
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
    }

    void Update()
    {
        if (isPlayerDead)
        {
            Time.timeScale = 0f;
            gameOver.enabled = true;
        }
    }
}
