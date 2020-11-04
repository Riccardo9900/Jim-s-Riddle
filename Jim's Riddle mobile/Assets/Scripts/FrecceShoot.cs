using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FrecceShoot : MonoBehaviour
{
    public GameObject player;
    public float forzaFreccia = 1f;

    public void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "FirePoint")
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * forzaFreccia);
        }
    }
}
