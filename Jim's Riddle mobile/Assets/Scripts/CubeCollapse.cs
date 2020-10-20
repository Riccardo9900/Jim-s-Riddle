using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollapse : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    //Mi distrugge il cubo (quindi i colpi nemici)
    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
           Destroy(gameObject);
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
