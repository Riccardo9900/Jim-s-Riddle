using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PavimentoRossoTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D coll)
    {
        if(coll.tag == "pavimentoRossoTutorial")
        {
            GameObject.FindGameObjectWithTag("PortaFine").GetComponent<Animator>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
