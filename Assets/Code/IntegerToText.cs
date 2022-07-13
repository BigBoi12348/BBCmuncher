using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IntegerToText : MonoBehaviour
{

    public int Tree = 0;
    public TextMeshProUGUI TreeText;

    public int Rock = 0;
    public TextMeshProUGUI RockText;

    public int Iron = 0;
    public TextMeshProUGUI IronText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This shows Changes the number on the inventory 
        TreeText.text = Tree.ToString();
        RockText.text = Rock.ToString();
        IronText.text = Iron.ToString();

    }
}
