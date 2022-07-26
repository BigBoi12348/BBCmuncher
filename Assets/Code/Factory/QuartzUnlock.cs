using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuartzUnlock : MonoBehaviour
{
    public Text quart;
    public GameObject Quartzfactory;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            if (QuartzCounter.Quartzy >= 30)
            {
                Quartzfactory.SetActive(true);
                Debug.Log("Money");
                QuartzCounter.Quartzy -= 30;
                quart.text = QuartzCounter.Quartzy.ToString();
            }
        }

    }
}
