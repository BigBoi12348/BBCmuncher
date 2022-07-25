using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManagerMeat : MonoBehaviour
{
    [SerializeField] private string meatTag = "Meat";
    [SerializeField] private GameObject chopText;
    [SerializeField] private float chopDamage = 1f;

    public GameObject impactEffect;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Transform selection = hit.transform;
            if (selection.CompareTag(meatTag))
            {
                if (hit.distance < 2f)
                {
                    chopText.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        selection.GetComponent<MeatManager>().ChopMeat(chopDamage);
                        GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                        Destroy(impactGO, 2f);
                    }

                }
            }
            else
            {
                chopText.SetActive(false);
            }
        }
    }
}
