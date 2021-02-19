using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class UltimaPepita : MonoBehaviour
{
    public GameObject passaggio;
    public GameObject canvasDialoghi;
    public GameObject dialogueManager;
    public Light2D luce;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            luce.intensity = 0.7f;
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
