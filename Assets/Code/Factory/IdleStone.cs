using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleStone : MonoBehaviour
{
    public Text rock;

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
        if (other.name.Equals("StoneMoney"))
        {
            RockCounter.Rockz += 2;
            rock.text = RockCounter.Rockz.ToString();
        }
    }
}
