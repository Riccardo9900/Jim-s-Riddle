using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour
{
    public float tempoInizioFreccia = 0f;
    public float tempoDurataFreccia = 0.2f;


   void Update()
    {
        if(tempoInizioFreccia>=tempoDurataFreccia)
        {
            Destroy(gameObject);
        }
        else
        {
            tempoInizioFreccia += Time.deltaTime;
        }
    }
}
