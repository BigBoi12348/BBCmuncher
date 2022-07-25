using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverTime : MonoBehaviour
{
    public float timer = 5f;
    public TreeManager tree; //link to tree health
    public bool isPoison;
    // Start is called before the first frame update
    void Start()
    {
        isPoison = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPoison)
        {
            timer -= Time.deltaTime;
            if (timer < 5)
            {
                
                //tree.tankHealth.CurrentHealth += 5 * Time.deltaTime; // damages the tank over time
                if (timer <= 0)
                {
                    timer = 5;
                    isPoison = false;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Poison"))
        {
            isPoison = true;
            Destroy(other.gameObject);
        }
    }
}
