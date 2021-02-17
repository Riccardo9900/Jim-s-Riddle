using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    public float speed = 500f;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wookong"))
        {
            Rigidbody2D rig = col.gameObject.GetComponent<Rigidbody2D>();
            if (rig == null) { 
                return; 
            }
            Vector2 velocity = rig.velocity;
            rig.AddForce(-velocity * speed);
        }
    }
}
