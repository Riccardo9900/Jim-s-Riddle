using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrecceDestroy : MonoBehaviour
{
    public Transform freccia;
    float collisionRadius = 0.4f;
    public bool collided = false;
    public LayerMask oggettoConCuiCollidere;

    void FixedUpdate()
    {
        collided = Physics2D.OverlapCircle(freccia.position, collisionRadius, oggettoConCuiCollidere);
        if (collided)
            Destroy(gameObject);
    }
    
}
