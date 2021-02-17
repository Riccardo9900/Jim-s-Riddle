using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestioneMovimentiDialogo : MonoBehaviour
{
    public GameObject canvasDialoghi;
    public GameObject dialogueManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canvasDialoghi.activeInHierarchy == true && dialogueManager.activeInHierarchy == true)
        {
            gameObject.GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<FireArrow>().enabled = false;
        }
        gameObject.GetComponent<PlayerMovement>().enabled = true;
        gameObject.GetComponent<FireArrow>().enabled = true;
    }
}
