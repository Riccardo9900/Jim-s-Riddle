using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fulmine : MonoBehaviour
{
    public float speed;
    public GameObject Arrow1;
    private Vector3 vettoreMovimentoFulmine;
    // Start is called before the first frame update
    void Start()
    {
        vettoreMovimentoFulmine = GameObject.FindGameObjectWithTag("Player").transform.position; /* Ho messo questo vettore nella start in modo che prenda le coordinate attuali.
                                                                                                  * Se lo avessi messo nella update si sarebbero aggiornate in continuazione le coordinate
                                                                                                  * e il player non poteva scappare dal colpo */
        
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), GameObject.FindGameObjectWithTag("Zeus").GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, vettoreMovimentoFulmine, speed * Time.deltaTime); //Funzione che da un vettore di partenza insegue un altro vettore

    }

    public void OnTriggerEnter2D (Collider2D coll)
    {
            distruggiFulmine();        
    }

  
    void distruggiFulmine()
    {
        Destroy(gameObject);
    }

}
