using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class ZeusAttack : MonoBehaviour
{
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

    void sparaFulmine()
    {
        if (player.transform.position.y >= -5.5) {
            Instantiate(Fulmine, PuntoDiSparo.position, Quaternion.Euler(player.GetComponent<FireArrow>().GetRotation(nuovoVettore))); //Crea il fulmine che partirà dalla mano di zeus ( punto di sparo ) 
        }
        else
        {
            if(Vector3.Distance(player.transform.position , transform.position) <= 5.5)
            {
                Instantiate(Fulmine, PuntoDiSparo.position, Quaternion.Euler(player.GetComponent<FireArrow>().GetRotation(nuovoVettore))); //Crea il fulmine che partirà dalla mano di zeus ( punto di sparo ) 
            }
        }
        Invoke("sparaFulmine", 5); // Qui ho richiamato ricorsivamente la funzione, in questo modo ogni 5 secondi spara. Se lo avessi messo nella Update si creavano fulmini per ogni frame
    }
}
   
