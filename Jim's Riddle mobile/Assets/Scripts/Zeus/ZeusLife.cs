using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusLife : MonoBehaviour
{
    public Healthbar healthBarScript;
    private float dannoFreccia;
    // Start is called before the first frame update
    void Start()
    {
        dannoFreccia = 5;
    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if(coll.collider.tag == "Arrow")
        {
            healthBarScript.health = healthBarScript.health - dannoFreccia;
        }
        if(healthBarScript.health == 0.0f)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
