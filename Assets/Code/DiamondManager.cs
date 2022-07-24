using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondManager : MonoBehaviour
{
    public float diamondHealth = 100f;
    public Text Diamond;
    private int diamond = 0;
    [SerializeField] Image foreground = null;

    public void ChopDiamond(float damage)
    {
        diamondHealth -= damage;

        foreground.fillAmount = diamondHealth / 100f;

        if (diamondHealth <= 0f)
        {
            Destroy(gameObject);
            DiamondCounter.Diamondz += Random.Range(+3, +5);
            Diamond.text = DiamondCounter.Diamondz.ToString();
        }
    }
}
