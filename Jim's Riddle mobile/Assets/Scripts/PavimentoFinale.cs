using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PavimentoFinale : MonoBehaviour
{
    public GameObject Wookong;
    public GameObject Chiusura;
    public Healthbar healthBarScript;
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

        void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.tag == "portaInizio")
            {
            Wookong.SetActive(true);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            gameObject.GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
            mainCamera.GetComponent<FollowPlayer>().enabled = false;
            mainCamera.GetComponent<AvantiWookong>().enabled = true;
            healthBarScript.enabled = true;
            Chiusura.SetActive(true);
        }
        }
        // Update is called once per frame
        void Update()
        {

        }
 }
