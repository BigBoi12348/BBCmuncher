using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockStore : MonoBehaviour
{
    public Text Wood;
    public Text Rock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.V))
        {
            if (WoodCounter.Woodz >= 10)
            {
                WoodCounter.Woodz -= 10;
                Wood.text = WoodCounter.Woodz.ToString();
                RockCounter.Rockz += 1;

                Debug.Log("Hit");
            }
            
            Rock.text = RockCounter.Rockz.ToString();
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //if (Input.GetKeyUp(KeyCode.V))
        //{
            
            //if (WoodCounter.Woodz >= 10)
            //{
            //    WoodCounter.Woodz -= 10;
            //    Wood.text = WoodCounter.Woodz.ToString();
            //    RockCounter.Rockz += 1;
            //    Rock.text = RockCounter.Rockz.ToString();
            //    Debug.Log("Hit");
            //}
            
        //}
    }

    
}
