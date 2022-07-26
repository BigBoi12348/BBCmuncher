using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeManager : MonoBehaviour
{
    public Text Wood;
    private int wood = 0;
    public float treeHealth = 10f;
    [SerializeField] Image foreground = null;
    public TreeManager tree;
    public float maxHealth = 10f;


    void Start()
    {
        
    }
    public void ChopTree(float damage)
    {
        treeHealth -= damage;

        foreground.fillAmount = treeHealth / 10f;

        if (treeHealth <= 0f)
        {
            Destroy(gameObject);

            WoodCounter.Woodz += Random.Range(+3, +11);
            Wood.text = WoodCounter.Woodz.ToString();
            
        }
        
    }
    void Update()
    {
        
    }
}
