using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject VictoryScreen;
    public GameObject Miner_Character;
    public GameObject Victorytheme;
    public GameObject MusicLittleRootGame;



    // Update is called once per frame
    void Update()
    {
        if (WoodCounter.Woodz >= 1000 & RockCounter.Rockz >= 1000 & QuartzCounter.Quartzy >= 300 & DiamondCounter.Diamondz >= 20)
        {
            VictoryScreen.SetActive(true);
            Miner_Character.SetActive(false);
            Victorytheme.SetActive(true);
            MusicLittleRootGame.SetActive(false);
        }
    }
}
