using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivazioneDialoghi : MonoBehaviour
{
    public GameObject canvasDialoghi;
    public GameObject DialogueManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if(coll.collider.tag == "PortaFine")
        {
            canvasDialoghi.SetActive(true);
            DialogueManager.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
