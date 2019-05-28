using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    private bool fall;
    public GameObject player;

    public Transform spawnPoint;
    
    public bool stomp;


    // Update is called once per frame
    void Update()
    {
    }
   void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            other.transform.position = spawnPoint.position;
        }
        
    }
}
