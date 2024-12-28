using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField] float MaxTime = 60f;
    [SerializeField] float remainingtime = 45f;

    private bool isDead;
    public GameManagerScript gameManager;

    void Update()
    {
        
        remainingtime -= Time.deltaTime;
        remainingtime = Mathf.Clamp(remainingtime, 0, MaxTime);
        
        UpdateTimerDisplay();

        if (remainingtime <= 0 && !isDead)
        {   isDead = true;
            gameManager.GameOver();
        }
        
    }

    public void IncreasedTime(float time)
    {
        remainingtime =+ time;
        // Ensure time does not goes bellow min or excced maxValue
        remainingtime = Mathf.Clamp(remainingtime, 0, MaxTime);
    }
    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    // private void GameOver()
    // {   
    //     isDead = true;
    //     remainingtime = 0;
    //     Debug.Log("GameOver!!!");

    //     Time.timeScale = 0;

    // }

    
}
