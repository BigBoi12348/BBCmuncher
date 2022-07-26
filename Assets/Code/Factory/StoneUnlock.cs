using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneUnlock : MonoBehaviour
{
    public Text rock;
    public GameObject stonefactory;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            if (RockCounter.Rockz >= 50)
            {
                stonefactory.SetActive(true);
                Debug.Log("Money");
                RockCounter.Rockz -= 50;
                rock.text = RockCounter.Rockz.ToString();
            }
        }

    }
}
