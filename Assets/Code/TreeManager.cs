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
    public bool isPoison;
    public TreeManager tree;
    public float timer = 5f;
    public float maxHealth = 10f;


    void Start()
    {
        isPoison = false;
    }
    public void ChopTree(float damage)
    {
        treeHealth -= damage;

        foreground.fillAmount = treeHealth / 10f;

        if (treeHealth <= 0f)
        {
            //Destroy(gameObject);
            isPoison = true;
            WoodCounter.Woodz += Random.Range(+3, +11);
            Wood.text = WoodCounter.Woodz.ToString();
            
        }
        
    }
    void Update()
    {
        if (isPoison)
        {
            timer -= Time.deltaTime;
            if (timer > 0)
            {
                foreground.fillAmount += 0.25f * Time.deltaTime;
                if (treeHealth >= maxHealth)
                {
                    treeHealth = 10f;
                    timer = 5f;
                    isPoison = false;
                    
                }
                else
                {
                    tree.treeHealth += 2.5f * Time.deltaTime; // damages the tank over time

                }
            }
        }
    }
}
