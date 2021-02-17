using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimaPepita : MonoBehaviour
{
    public GameObject passaggio;
    public GameObject canvasDialoghi;
    public GameObject dialogueManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            dialogueManager.SetActive(true);
            canvasDialoghi.SetActive(true);
            passaggio.SetActive(true);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
