using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverUI;

    private void Awake() {
        isGameOver = false;
    }
    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Update() {
        if (isGameOver)
        {
            GameOver();
        }
    }
}
