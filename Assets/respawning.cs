using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawning : MonoBehaviour
{
    [SerializeField]
    Transform spawnPoint;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            other.transform.position = spawnPoint.position;
        }
    }
    
}
