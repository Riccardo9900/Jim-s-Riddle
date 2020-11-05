using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrecceDestroy : MonoBehaviour
{
    public Transform freccia;
    float collisionRadius = 0.4f;
    public bool collided = false;
    public float tempoInizioLancio = 0f;
    public float tempoFreccia = 2f;
    public LayerMask oggettoConCuiCollidere;

    void Start()
    {

    }

    void FixedUpdate()
    {
        collided = Physics2D.OverlapCircle(freccia.position, collisionRadius, oggettoConCuiCollidere);
        if (collided)
        {
            Destroy(gameObject);
           // tempoInizioLancio = 0f;
        }
         
    }

}
