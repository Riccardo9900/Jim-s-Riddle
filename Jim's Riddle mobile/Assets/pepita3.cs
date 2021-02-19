using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepita3 : MonoBehaviour
{
    public GameObject pepita4;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            Destroy(gameObject);
            pepita4.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
