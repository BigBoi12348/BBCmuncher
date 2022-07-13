using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeldItemManager : MonoBehaviour
{

    public int SelectedItem = 0;
    // Start is called before the first frame update
    void Start()
    {
        HeldItem();  
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedItem = SelectedItem;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (SelectedItem >= transform.childCount - 1)
                SelectedItem = 0;
            else
                SelectedItem++;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (SelectedItem <= transform.childCount - 1)
                SelectedItem = 0;
            else
                SelectedItem--;
        }

        //number Input to select item
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SelectedItem = 0;
        }

        // the && makes sure there isn't two items. This is for when we add more slots
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >=2)
        {
            SelectedItem = 1;
        }

        /*
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 3)
        {
            SelectedItem = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 4)
        {
            SelectedItem = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 5)
        {
            SelectedItem = 4;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 6)
        {
            SelectedItem = 5;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 7)
        {
            SelectedItem = 6;
        }

         if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 8)
        {
            SelectedItem = 7;
        }

         if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 9)
        {
            SelectedItem = 8;
        }
        */

        if (previousSelectedItem != SelectedItem)
        {
            HeldItem();
        }
    }

    void HeldItem ()
    {
        int i = 0;
        foreach (Transform item in transform)
        {
            if (i == SelectedItem)
                item.gameObject.SetActive(true);
            else
                item.gameObject.SetActive(false);
            i++;
        }
    }
}
