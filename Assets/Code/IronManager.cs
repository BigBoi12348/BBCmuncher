using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IronManager : MonoBehaviour
{
    public float ironHealth = 50f;
    public Text Iron;
    private int iron = 0;
    [SerializeField] Image foreground = null;

    public void ChopIron(float damage)
    {
        ironHealth -= damage;

        foreground.fillAmount = ironHealth / 50f;

        if (ironHealth <= 0f)
        {
            Destroy(gameObject);
            IronCounter.Ironz += Random.Range(+3, +5);
            Iron.text = IronCounter.Ironz.ToString();
        }
    }
}
