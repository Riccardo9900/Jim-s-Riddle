using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaInizio : MonoBehaviour
{
    public GameObject Porta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if(coll.collider.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().enabled = false;
            Porta.GetComponent<Animator>().enabled = true;
            Invoke("AperturaPorta", 1f);
        }
    }

    void AperturaPorta()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>().enabled = true;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
