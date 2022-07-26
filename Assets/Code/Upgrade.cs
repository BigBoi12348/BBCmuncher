using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    //code for text ui
    public Text wood;
    public Text stone;
    public Text quart;
    public Text Diamond;
    //Code for axe upgrade
    public GameObject axe;
    public GameObject saxe;
    public GameObject iaxe;
    public GameObject gaxe;
    public GameObject qaxe;
    public GameObject daxe;
    //Code for damage
    public GameObject tree;
    public GameObject rock;
    public GameObject iron;
    public GameObject gold;
    public GameObject quartz;
    public GameObject diamond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            if (WoodCounter.Woodz >=30)
            {
                axe.SetActive(false);
                saxe.SetActive(true);
                Debug.Log("Switch");
                //tree.SetActive(false);
                rock.SetActive(true);

                WoodCounter.Woodz -= 30;
                wood.text = WoodCounter.Woodz.ToString();

                //SelectionManagerDiamond DamageUpdate();
                //GetComponent<SelectionManagerDiamond>().chopDamage = +240f;
                //SelectionManagerDiamond.chopDamage = + 240;
                //SelectionManagerDiamond.chopDamage = 249f;
                //Instantiate<SelectionManagerDiamond>().ChopDiamond(chopDamage);
                //GetComponent<SelectionManagerDiamond>().chopDamage;
            }

        }
        //if (Input.GetKeyUp(KeyCode.Alpha2))
        //{
        //    saxe.SetActive(false);
        //    iaxe.SetActive(true);
        //    Debug.Log("Switch2");
        //    rock.SetActive(false);
        //    iron.SetActive(true);
        //}
        //if (Input.GetKeyUp(KeyCode.Alpha3))
        //{
        //    iaxe.SetActive(false);
        //    gaxe.SetActive(true);
        //    Debug.Log("Switch3");
        //    iron.SetActive(false);
        //    gold.SetActive(true);
        //}
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            if(RockCounter.Rockz >= 50)
            {
                saxe.SetActive(false);
                qaxe.SetActive(true);
                Debug.Log("Switch4");
                //gold.SetActive(false);
                quartz.SetActive(true);

                RockCounter.Rockz -= 50;
                stone.text = RockCounter.Rockz.ToString();
            }
            

        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            if(QuartzCounter.Quartzy >=50)
            qaxe.SetActive(false);
            daxe.SetActive(true);
            Debug.Log("Switch5");
            //quartz.SetActive(false);
            diamond.SetActive(true);

            QuartzCounter.Quartzy -= 50;
            quart.text = QuartzCounter.Quartzy.ToString();
        }
    }
}
