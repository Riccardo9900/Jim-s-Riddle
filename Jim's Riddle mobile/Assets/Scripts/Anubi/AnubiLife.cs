﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnubiLife : MonoBehaviour
{
    public Healthbar healthBarScript;
    public float dannoFreccia;
    public GameObject PassaggioLivello;

    // Start is called before the first frame update
    void Start()
    {
        PassaggioLivello.SetActive(false);
        dannoFreccia = 10;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Arrow")
        {
            healthBarScript.health = healthBarScript.health - dannoFreccia;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBarScript.health <= 0.0f)
        {
            Destroy(gameObject);
            PassaggioLivello.SetActive(true);
            Debug.Log("Hai sconfitto Anubi e hai attivato il passaggio per il prossimo livello!!");
        }
    }
}