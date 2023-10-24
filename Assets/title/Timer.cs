using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    bool timerActive = true;
    float currentTime;
    public int startMiuntes;
    public TextMeshProUGUI currentTimeText;

    void Start()
    {
        currentTime = startMiuntes * 60;
    }

    void Update()
    {
        if (timerActive == true)
        {
           currentTime = currentTime - Time.deltaTime;
           if(currentTime <= 0)
           {
             timerActive = false;
             SceneManager.LoadScene(15);
             
           }
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    
}
