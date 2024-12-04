using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float countDown = 120f;
    public GameEnding gameEnding;

    private bool countDownOn = true;

    void Update()
    {
        if (countDownOn)
        {
            if (countDown > 0)
            {
                countDown -= Time.deltaTime;
                UpdateDisplay(countDown);
            }
            else
            {
                countDown = 0;
                countDownOn = false;
                UpdateDisplay(countDown);
                if (countDown == 0)
                {
                    gameEnding.TimeUp();
                }
            }
        }
    }

    void UpdateDisplay(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
