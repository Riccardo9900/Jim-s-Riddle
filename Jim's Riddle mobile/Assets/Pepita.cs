using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pepita : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D coll)
    {
        if(coll.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
