using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrecciaMovement : MonoBehaviour
{
    public GameObject freccia;
    public float velocitàFreccia = 2f;
    public float durataTempoFreccia = 2f;
    float tempoPassatoDaInizioFreccia = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        StopCorsa();
    }

    void Movement()
    {
        transform.position += transform.up * Time.deltaTime * velocitàFreccia;
    }

    void StopCorsa()
    {
        tempoPassatoDaInizioFreccia += Time.deltaTime;
        if(durataTempoFreccia >= tempoPassatoDaInizioFreccia)
        {
            Destroy(freccia);
        }
    }
}
