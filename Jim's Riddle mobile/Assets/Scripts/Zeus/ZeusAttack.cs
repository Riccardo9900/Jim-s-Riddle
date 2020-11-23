using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class ZeusAttack : MonoBehaviour
{
    public Healthbar healthbarScript;
    public Transform PuntoDiSparo;
    public GameObject Fulmine;
    private GameObject player;
    private Vector3 nuovoVettore;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Invoke("sparaFulmine", 0.0f); //dopo 5 secondi richiama la funzione sparaFulmine
    }

    // Update is called once per frame
    void Update()
    {
        nuovoVettore = transform.position - player.transform.position;
    }

    public void sparaFulmine()
    {
        if (player.transform.position.y >= -5.5) {
            if (healthbarScript.health > 66)
            {
                sparaFulmineSingolo();
            }
            if (healthbarScript.health < 66 && healthbarScript.health > 33)
            {
                sparaFulmineDoppio();
            }
            if (healthbarScript.health <= 33)
            {
                sparaFulmineTriplo();
            }
        }
        else
        {
            if(Vector3.Distance(player.transform.position , transform.position) <= 5.5)
            {
                if (healthbarScript.health > 66)
                {
                    sparaFulmineSingolo();
                }
                if (healthbarScript.health < 66 && healthbarScript.health > 33)
                {
                    sparaFulmineDoppio();
                }
                if (healthbarScript.health <= 33)
                {
                    sparaFulmineTriplo();
                }
            }
        }
        Invoke("sparaFulmine", 4.5f); // Qui ho richiamato ricorsivamente la funzione, in questo modo ogni 5 secondi spara. Se lo avessi messo nella Update si creavano fulmini per ogni frame
    }

    void sparaFulmineSingolo ()
    {
        Instantiate(Fulmine, PuntoDiSparo.position, Quaternion.Euler(player.GetComponent<FireArrow>().GetRotation(nuovoVettore)));
    }

    void sparaFulmineDoppio ()
    {
        sparaFulmineSingolo();
        Invoke("sparaFulmineSingolo", 0.8f);
    }
    
    void sparaFulmineTriplo ()
    {
        sparaFulmineSingolo();
        Invoke("sparaFulmineDoppio", 0.8f);
    }
}
   
