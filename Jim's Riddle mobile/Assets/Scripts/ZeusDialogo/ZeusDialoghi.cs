using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusDialoghi : MonoBehaviour
{
    public GameObject zeus;
    public GameObject canvasDialoghi;
    public GameObject DialogueManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(zeus == null)
        {
            canvasDialoghi.SetActive(true);
            DialogueManager.SetActive(true);
        }
    }
}
