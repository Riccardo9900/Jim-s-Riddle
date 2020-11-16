using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public Healthbar healthBarScript;
    private float dannoFreccia;
    // Start is called before the first frame update
    void Start()
    {
        dannoFreccia = 10;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.tag == "Scheletro")
        {
            healthBarScript.health = healthBarScript.health - dannoFreccia;
            Debug.Log(healthBarScript.health);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
