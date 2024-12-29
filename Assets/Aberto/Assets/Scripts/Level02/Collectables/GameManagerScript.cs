using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    // public static GameManagerScript newgamemanager { get; private set; }
    // public UnitHealth _playerStamina = new UnitHealth(100, 100);
    
    // void Awake()
    // {
    //     if (newgamemanager != null && newgamemanager != this)
    //     {
    //         Destroy(this);
    //     }
    //     else
    //     {
    //         newgamemanager = this;
    //     }
    // }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
