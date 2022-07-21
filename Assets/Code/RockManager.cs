using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RockManager : MonoBehaviour
{
    public float rockHealth = 20f;
    public Text Rock;
    private int rock = 0;
    [SerializeField] Image foreground = null;

    public void ChopRock(float damage)
    {
        rockHealth -= damage;

        foreground.fillAmount = rockHealth / 20f;

        if (rockHealth <= 0f)
        {
            Destroy(gameObject);
            RockCounter.Rockz += Random.Range(+3, +5);
            Rock.text = RockCounter.Rockz.ToString();
        }
    }

}
