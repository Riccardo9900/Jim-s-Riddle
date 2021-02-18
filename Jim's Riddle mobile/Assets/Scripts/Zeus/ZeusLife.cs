using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusLife : MonoBehaviour
{
    public Healthbar healthBarScript;
    private float dannoFreccia;

    public GameObject dialogueManager;
    public GameObject canvasDialoghi;
    public GameObject portaleFinale;
    // Start is called before the first frame update
    void Start()
    {
        dannoFreccia = 5;
    }

    void OnTriggerEnter2D (Collider2D coll)
    {
        if(coll.tag == "Arrow")
        {
            healthBarScript.health = healthBarScript.health - dannoFreccia;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBarScript.health == 0.0f)
        {
            canvasDialoghi.SetActive(true);
            dialogueManager.SetActive(true);
            portaleFinale.SetActive(true);
            Destroy(gameObject);
        }
    }
}
