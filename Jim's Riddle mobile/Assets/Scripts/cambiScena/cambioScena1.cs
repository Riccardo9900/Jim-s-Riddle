using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioScena1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "changeScene")
        {
            SceneManager.LoadScene("Riccardo");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
