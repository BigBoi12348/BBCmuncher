using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MeatManager : MonoBehaviour
{
    public float meatHealth = 50f;
    public Text Meat;
    private int meat = 0;
    [SerializeField] Image foreground = null;

    public void ChopMeat(float damage)
    {
        meatHealth -= damage;

        foreground.fillAmount = meatHealth / 50f;

        if (meatHealth <= 0f)
        {
            Destroy(gameObject);
            MeatCounter.Meatz += Random.Range(+3, +5);
            Meat.text = MeatCounter.Meatz.ToString();
        }
    }
}
