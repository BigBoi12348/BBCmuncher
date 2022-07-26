using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IdleQuartz : MonoBehaviour
{
    public Text quart;

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
        if (other.name.Equals("QuartzMoney"))
        {
            QuartzCounter.Quartzy += 1;
            quart.text = QuartzCounter.Quartzy.ToString();
        }
    }
}
