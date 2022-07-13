using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RockManager : MonoBehaviour
{
    public float rockHealth = 10f;
    [SerializeField] Image foreground = null;

    public void ChopRock(float damage)
    {
        rockHealth -= damage;

        foreground.fillAmount = rockHealth / 10f;

        if (rockHealth <= 0f)
        {
            Destroy(gameObject);
        }
    }

}
