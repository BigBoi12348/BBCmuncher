using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodUnlock : MonoBehaviour
{
    public Text wood;
    public GameObject woodfactory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            if (WoodCounter.Woodz >= 100)
            {
                woodfactory.SetActive(true);
                Debug.Log("Money");
                WoodCounter.Woodz -= 100;
                wood.text = WoodCounter.Woodz.ToString();
            }
        }
        
    }
}
