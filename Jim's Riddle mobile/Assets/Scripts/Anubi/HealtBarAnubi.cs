using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBarAnubi : MonoBehaviour
{

    public GameObject healthBarAnubi;

    // Start is called before the first frame update
    void Start()
    {
        healthBarAnubi.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Arrow")
        {
            healthBarAnubi.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
