using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheletroDestroy : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player" || col.tag == "Arrow")
        {
            Destroy(gameObject);
        }
    }


}
