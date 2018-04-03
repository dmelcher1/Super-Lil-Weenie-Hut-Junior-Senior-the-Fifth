using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour
{
    private float timeRemaining;
    public Text timer;

    void Start()
    {
        timeRemaining = 300;
    }
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining > 0)
        {
            float minutes = Mathf.Floor(timeRemaining / 60);
            float seconds = Mathf.Floor(timeRemaining % 60);
            timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }
}