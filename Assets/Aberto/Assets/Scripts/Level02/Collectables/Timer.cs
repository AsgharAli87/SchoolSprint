using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField] float remainingtime;

    void Update()
    {
        if (remainingtime > 0)
        {
        remainingtime -= Time.deltaTime;
        }
        else if (remainingtime < 0)
        {
            remainingtime = 0;
            //GameOver();
            timertext.color = Color.red;
        }
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
