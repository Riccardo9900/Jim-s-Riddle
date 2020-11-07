using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
   
    public Animator playerAnimation;
    public GameObject deathPanel;
    public GameObject GameOver;
    public GameObject descriptioGameOver;
    public GameObject buttonRespawn;
    public GameObject player;
    public GameObject toDestroy;
    public GameObject tastoPausa;


    // Start is called before the first frame update
    void Start()
    {
        deathPanel.SetActive(false);
        GameOver.SetActive(false);
        buttonRespawn.SetActive(false);
        descriptioGameOver.SetActive(false);
        tastoPausa.SetActive(true);
    }

    //Vede se faccio ua collisione con un oggetto nemico (in questo caso con il cubo rosso con il tag DeathCube) e lo distrugge. 
    //Disattiva il movimento del player bloccando ogni input da tastiera e attiva i pannelli di morte (bottone, pannello e scritta)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeathElement"))
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
        buttonRespawn.SetActive(true);
        tastoPausa.SetActive(false);
        GetComponent<PlayerMovement>().enabled = false;
    }

    //Respawna il player facendolo tornare alla posizione iniziale riattivando il movimento e disattiva i pannelli di morte
    public void Respawn()
    {
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<Animator>().enabled = true;
        tastoPausa.SetActive(true);
        buttonRespawn.SetActive(false);
        GameOver.SetActive(false);
        descriptioGameOver.SetActive(false);
        deathPanel.SetActive(false);
        GetComponent<PauseManage>().ReloadScene();
        Debug.Log("Hai respawnato");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
