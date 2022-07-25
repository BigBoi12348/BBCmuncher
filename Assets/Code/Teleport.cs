using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private Transform respawnPoint;




    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
