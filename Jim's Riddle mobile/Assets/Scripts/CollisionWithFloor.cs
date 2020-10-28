﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithFloor : MonoBehaviour
{
    public GameObject deathPanel;
    // Start is called before the first frame update
    void Start()
    {
        this.deathPanel.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Pavimento Sbagliato")
        {
            this.deathPanel.SetActive(true);
            GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
