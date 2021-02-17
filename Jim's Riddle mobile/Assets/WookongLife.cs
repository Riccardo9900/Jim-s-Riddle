using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WookongLife : MonoBehaviour
{
    public Healthbar healthBarScript;
    public float dannoFreccia;
    private GameObject PassaggioLivello;
    private GameObject dialogueManager;
    private GameObject canvasDialoghi;

    // Start is called before the first frame update
    void Start()
    {
        healthBarScript.enabled = false;
        dannoFreccia = 10;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Arrow")
        {
            healthBarScript.enabled = true;
            healthBarScript.health = healthBarScript.health - dannoFreccia;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBarScript.health <= 0.0f)
        {
            Destroy(gameObject);
            Debug.Log("Hai sconfitto Anubi e hai attivato il passaggio per il prossimo livello!!");
        }
    }
}
