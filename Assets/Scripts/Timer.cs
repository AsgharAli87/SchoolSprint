using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    // Start is called before the first frame update
    [SerializeField] public float remainingTime;
    public GameManagerScript gameManager;

    private bool isDead;

    // Update is called once per frame
    void Update()
    {

        if (remainingTime <= 0 && !isDead)
        {
            FreezeGame();
            timerText.color = Color.red;
            isDead = true;
            gameManager.GameOver();
        }
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        

    }

    private void FreezeGame()
    {
        Debug.Log("Health is zero! Game is now frozen.");
        Time.timeScale = 0; // Freeze the game
    }


}
