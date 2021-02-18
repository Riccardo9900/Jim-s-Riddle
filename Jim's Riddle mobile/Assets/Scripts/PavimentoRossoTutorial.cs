using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PavimentoRossoTutorial : MonoBehaviour
{
    public GameObject passaporta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D coll)
    {
        if(coll.tag == "pavimentoRossoTutorial")
        {
            passaporta.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
