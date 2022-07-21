using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoldManager : MonoBehaviour
{
    public float goldHealth = 100f;
    public Text Gold;
    private int gold = 0;
    [SerializeField] Image foreground = null;

    public void ChopGold(float damage)
    {
        goldHealth -= damage;

        foreground.fillAmount = goldHealth / 100f;

        if (goldHealth <= 0f)
        {
            Destroy(gameObject);
            GoldCounter.Goldz += Random.Range(+3, +5);
            Gold.text = GoldCounter.Goldz.ToString();
        }
    }
}
