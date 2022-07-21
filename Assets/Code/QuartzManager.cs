using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuartzManager : MonoBehaviour
{
    public float quartzHealth = 150f;
    public Text Quartz;
    private int quartz = 0;
    [SerializeField] Image foreground = null;

    public void ChopQuartz(float damage)
    {
        quartzHealth -= damage;

        foreground.fillAmount = quartzHealth / 150f;

        if (quartzHealth <= 0f)
        {
            Destroy(gameObject);
            QuartzCounter.Quartzy += Random.Range(+3, +5);
            Quartz.text = QuartzCounter.Quartzy.ToString();
        }
    }
}
