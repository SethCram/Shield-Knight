using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreen;
    public TMP_Text scoreText;
    public TMP_Text titleText;
    public bool gameIsOver;

    // Start is called before the first frame update
    private void Start()
    {
        winScreen.SetActive(false);
        scoreText.text = PlayerManager.instance.GetPlayerScore().ToString();
        titleText.text = PlayerManager.instance.GetPlayerTitle();
        gameIsOver = false;
    }

    // Update is called once per frame
    private void Update()
    {
        scoreText.text = PlayerManager.instance.GetPlayerScore().ToString();
        titleText.text = PlayerManager.instance.GetPlayerTitle();

        if(!gameIsOver && PlayerManager.instance.GameIsWon())
        {
            gameIsOver = true;
            winScreen.SetActive(true);
        }
    }

    public void CloseWinScreen()
    {
        winScreen.SetActive(false);
    }
}