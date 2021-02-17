﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioCameraManage : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject healtBarWookong;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if(coll.collider.tag == "portaInizio")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            gameObject.GetComponent<PlayerMovement>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
            mainCamera.GetComponent<FollowPlayer>().enabled = false;
            mainCamera.GetComponent<avanti>().enabled = true;
            healtBarWookong.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
