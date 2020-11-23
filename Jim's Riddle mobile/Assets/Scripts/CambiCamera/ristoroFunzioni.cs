using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ristoroFunzioni : MonoBehaviour
{
    public GameObject player;
    public GameObject portaInizio;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<indietro>().enabled = false;
        player.GetComponent<cambioCameraManage>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<FollowPlayer>().enabled = true;
        Destroy(portaInizio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
