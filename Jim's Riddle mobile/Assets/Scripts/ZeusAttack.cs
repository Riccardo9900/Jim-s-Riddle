using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class ZeusAttack : MonoBehaviour
{
    public Transform PuntoDiSparo;
    public GameObject Fulmine;

    public float Sparo;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("sparaFulmine", 5); //dopo 5 secondi richiama la funzione sparaFulmine
    }

    // Update is called once per frame
    void Update()
    {

    }

    void sparaFulmine()
    {
        Instantiate(Fulmine, PuntoDiSparo.position, transform.rotation); //Crea il fulmine che partirà dalla mano di zeus ( punto di sparo ) 
        Invoke("sparaFulmine", 5); // Qui ho richiamato ricorsivamente la funzione, in questo modo ogni 5 secondi spara. Se lo avessi messo nella Update si creavano fulmini per ogni frame.
    }
}
   
