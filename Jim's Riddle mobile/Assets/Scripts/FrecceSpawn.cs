using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrecceSpawn : MonoBehaviour
{
    public GameObject freccia;
    public Transform spawnPoint;

    void FixedUpdate()
    {
        bool shoot = Input.GetKeyDown(KeyCode.L);
        if (shoot) 
            Instantiate(freccia, spawnPoint.position, spawnPoint.rotation);
    }
}
