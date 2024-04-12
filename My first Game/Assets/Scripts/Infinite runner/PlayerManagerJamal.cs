using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;
    public static int numberOfCoins;
    public TMPro.TMP_Text CoinsText;
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberOfCoins = 0;
    }


    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        CoinsText.text = "Coins: " + numberOfCoins;

        if (Input.GetMouseButtonDown(0))

        {
            isGameStarted = true;
            Destroy(startingText);
            FindObjectOfType<AudioManager>().PlaySound("MainTheme");
        }
    }
}