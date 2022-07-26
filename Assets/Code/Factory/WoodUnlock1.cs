using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodUnlock1 : MonoBehaviour
{
    public Text quart;
    public GameObject woodfactory2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.G))
        {
            if (QuartzCounter.Quartzy >= 15)
            {
                woodfactory2.SetActive(true);
                Debug.Log("Money");
                QuartzCounter.Quartzy -= 15;
                quart.text = QuartzCounter.Quartzy.ToString();
            }
        }
        
    }
}
