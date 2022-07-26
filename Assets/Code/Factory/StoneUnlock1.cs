using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneUnlock1 : MonoBehaviour
{
    public Text diamond;
    public GameObject stonefactory2;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.J))
        {
            if (DiamondCounter.Diamondz >= 5)
            {
                stonefactory2.SetActive(true);
                Debug.Log("Money");
                DiamondCounter.Diamondz -= 5;
                diamond.text = DiamondCounter.Diamondz.ToString();
            }
        }

    }
}
