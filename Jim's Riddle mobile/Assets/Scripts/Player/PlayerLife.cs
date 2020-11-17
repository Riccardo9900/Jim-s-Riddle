using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public HealthbarPlayer healthBarScript;
    public float dannoScheletro;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        dannoScheletro = 10;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Scheletro")
        {
            healthBarScript.health = healthBarScript.health - dannoScheletro;
            Debug.Log(healthBarScript.health);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(healthBarScript.health <= 0)
        {
            player.GetComponent<PlayerDamage>().Death();
        }
    }
}
