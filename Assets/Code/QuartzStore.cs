using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuartzStore : MonoBehaviour
{
    public Text Quartz;
    public Text Rock;
    //public GameObject buy;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Y))
        {
            //buy.SetActive(true);
            if (RockCounter.Rockz >= 25)
            {
                RockCounter.Rockz -= 25;
                Rock.text = RockCounter.Rockz.ToString();
                QuartzCounter.Quartzy += 1;

                Debug.Log("Hit");
            }

            Quartz.text = QuartzCounter.Quartzy.ToString();
        }

    }
}
