using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleWood : MonoBehaviour
{
    public Text wood;
    
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
        if (other.name.Equals("WoodMoney"))
        {
            WoodCounter.Woodz += 5;
            wood.text = WoodCounter.Woodz.ToString();
        }
    }
}
