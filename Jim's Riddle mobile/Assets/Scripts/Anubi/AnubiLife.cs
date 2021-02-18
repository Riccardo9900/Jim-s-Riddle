using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnubiLife : MonoBehaviour
{
    public Healthbar healthBarScript;
    public float dannoFreccia;
    public GameObject PassaggioLivello;
    public GameObject dialogueManager;
    public GameObject passaPorta;
    public GameObject canvasDialoghi;

    public GameObject spawnpoint1;
    public GameObject spawnpoint2;
    public GameObject spawnpoint3;
    public GameObject spawnpoint4;
    public GameObject spawnpoint5;

    // Start is called before the first frame update
    void Start()
    {
        PassaggioLivello.SetActive(false);
        dannoFreccia = 10;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Arrow")
        {
            healthBarScript.health = healthBarScript.health - dannoFreccia;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (healthBarScript.health <= 0.0f)
        {
            Destroy(spawnpoint1);
            Destroy(spawnpoint2);
            Destroy(spawnpoint3);
            Destroy(spawnpoint4);
            Destroy(spawnpoint5);
            Destroy(gameObject);
            passaPorta.SetActive(true);
            canvasDialoghi.SetActive(true);
            dialogueManager.SetActive(true);
            PassaggioLivello.SetActive(true);
            Debug.Log("Hai sconfitto Anubi e hai attivato il passaggio per il prossimo livello!!");
        }
    }
}
