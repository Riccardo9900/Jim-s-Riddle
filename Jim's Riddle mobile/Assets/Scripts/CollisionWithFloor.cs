using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithFloor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D coll)
    {
        if (coll.tag == "Pavimento Sbagliato")
        {
            Debug.Log("Collisione con pavimento sbagliato!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
