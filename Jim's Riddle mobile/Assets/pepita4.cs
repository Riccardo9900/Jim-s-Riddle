using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pepita4 : MonoBehaviour
{
    public GameObject pepita5;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            Destroy(gameObject);
            pepita5.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
