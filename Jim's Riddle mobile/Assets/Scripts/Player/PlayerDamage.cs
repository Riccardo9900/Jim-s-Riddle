﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField]
    public Animator playerAnimation;
    public GameObject deathPanel;
    public GameObject GameOver;
    public GameObject descriptioGameOver;
    public GameObject button;
    public GameObject player;
    public GameObject toDestroy;
    public GameObject tastoPausa;


    // Start is called before the first frame update
    void Start()
    {
        deathPanel.SetActive(false);
        GameOver.SetActive(false);
        button.SetActive(false);
        descriptioGameOver.SetActive(false);
        tastoPausa.SetActive(true);
    }

    //Vede se faccio ua collisione con un oggetto nemico (in questo caso con il cubo rosso con il tag DeathCube) e lo distrugge. 
    //Disattiva il movimento del player bloccando ogni input da tastiera e attiva i pannelli di morte (bottone, pannello e scritta)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeathCube")
        {
            Debug.Log("Hai preso il cubo sbagliato");
            Destroy(toDestroy);
            Death();
        }
    }
    public void Death()
    {
        Debug.Log("Sei morto!");
        playerAnimation.SetBool("Death", true);
 
        deathPanel.SetActive(true);
        GameOver.SetActive(true);
        descriptioGameOver.SetActive(true);
        button.SetActive(true);
        tastoPausa.SetActive(false);
        GetComponent<PlayerMovement>().enabled = false;
    }

    //Respawna il player facendolo tornare alla posizione iniziale riattivando il movimento e disattiva i pannelli di morte
    public void Respawn()
    {
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<Animator>().enabled = true;
        tastoPausa.SetActive(true);
        button.SetActive(false);
        GameOver.SetActive(false);
        descriptioGameOver.SetActive(false);
        deathPanel.SetActive(false);
        SceneManager.LoadScene("TESTMORTE");
        Debug.Log("Hai respawnato");
    }


    // Update is called once per frame
    void Update()
    {

    }
}
