﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusDeath : MonoBehaviour
{
    public Healthbar healthBarScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBarScript.health == 0.0f)
        {
            Destroy(gameObject);
            
        }
    }
}