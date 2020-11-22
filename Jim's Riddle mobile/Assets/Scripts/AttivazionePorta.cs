using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivazionePorta : MonoBehaviour
{
    public GameObject player, porta;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
        porta.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("Hai chiuso la porta!");
            //fai partire l'animazione della porta (da aggiungere) e quelle di Riccardo (potremo semplicemente unire questo script nei suoi)
            
          
            porta.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
    
}
