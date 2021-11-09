using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameStartCanvas;
    public GameObject gameScoreCanvas;

    void Start()
    {
        Time.timeScale = 0;
    }
    
    public void gameStart()
    {
        gameStartCanvas.SetActive(false);
        gameScoreCanvas.SetActive(true);
        Time.timeScale = 1;
    }


    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

    public void ExiGame()
    {
        Application.Quit();
    }
}
