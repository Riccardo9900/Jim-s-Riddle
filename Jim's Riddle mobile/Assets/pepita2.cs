using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepita2 : MonoBehaviour
{
    public GameObject pepita3;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            Destroy(gameObject);
            pepita3.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
