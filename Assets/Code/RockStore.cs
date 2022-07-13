using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockStore : MonoBehaviour
{
    public Text Wood;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(WoodCounter.Woodz >= 10)
        {
            WoodCounter.Woodz -= 10;
            Wood.text = WoodCounter.Woodz.ToString();
            Debug.Log("Hit");
        }
    }
}
