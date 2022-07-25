using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimeLeft;
    public bool TimerOn = false;

    public Text Timertxt;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    //If player hits obstacles, timer goes down by 1 second
    


    // Update is called once per frame
    void Update()
    {
        if (TimerOn) // check if timer is activated on script
        {
            if (TimeLeft > 0) // if timer is freater than 0, then timer will go down
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Timer is up");
                TimeLeft = 0;
                TimerOn = false;
            }
        }
    }


    //Refference min, and seconds 
    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        Timertxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);

    }
}
