using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverUI;
<<<<<<< HEAD
    public GameObject levelMenuUI;
    

=======

    private void Awake() {
        isGameOver = false;
    }
>>>>>>> origin/master
    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
<<<<<<< HEAD
    public void LevelComplete()
    {
        levelMenuUI.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
=======

    void Update() {
        if (isGameOver)
        {
            GameOver();
        }
>>>>>>> origin/master
    }
}
