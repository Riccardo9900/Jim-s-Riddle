using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fulmine : MonoBehaviour
{
    public float speed;
    private Vector3 vettoreMovimentoFulmine;
    // Start is called before the first frame update
    void Start()
    {
        vettoreMovimentoFulmine = GameObject.FindGameObjectWithTag("Player").transform.position; /* Ho messo questo vettore nella start in modo che prenda le coordinate attuali.
                                                                                                  * Se lo avessi messo nella update si sarebbero aggiornate in continuazione le coordinate
                                                                                                  * e il player non poteva scappare dal colpo */
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, vettoreMovimentoFulmine, speed * Time.deltaTime); //Funzione che da un vettore di partenza insegue un altro vettore
        if(transform.position == vettoreMovimentoFulmine )
        {
            distruggiFulmine();
        }
    }

    public void OnTriggerEnter2D (Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            Debug.Log("Il player è stato colpito");
            distruggiFulmine();
        }
        else
        {
            if(coll.tag != "Zeus")
            distruggiFulmine();
        }
    }


    void distruggiFulmine ()
    {
        Destroy(gameObject);
    }

}
