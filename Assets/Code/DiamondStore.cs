using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DiamondStore : MonoBehaviour
{
    public Text Quartz;
    public Text Diamond;
    //public GameObject buy;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.U))
        {
            //buy.SetActive(true);
            if (QuartzCounter.Quartzy >= 15)
            {
                QuartzCounter.Quartzy -= 15;
                Quartz.text = QuartzCounter.Quartzy.ToString();
                DiamondCounter.Diamondz += 1;

                Debug.Log("Hit");
            }

            Diamond.text = DiamondCounter.Diamondz.ToString();
        }

    }
}
