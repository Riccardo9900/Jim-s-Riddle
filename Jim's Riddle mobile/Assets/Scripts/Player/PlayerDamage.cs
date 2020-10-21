using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField]
    public GameObject deathPanel;
    public GameObject deathText;
    public GameObject buttonDescription;
    public GameObject button;
    public GameObject player;
    public GameObject goalLabel;
    public GameObject toDestroy;
    public GameObject secretPassage;
    public GameObject tastoImpostazioni;
    public RedCubeFollowing cubo;

    // Start is called before the first frame update
    void Start()
    {
        goalLabel.SetActive(true);
        deathPanel.SetActive(false);
        deathText.SetActive(false);
        buttonDescription.SetActive(false);
        button.SetActive(false);
        tastoImpostazioni.SetActive(true);
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
        else
        {
            if(collision.tag == "SecretPassage")
            {
                Destroy(secretPassage);
            }
        }
    }
    public void Death()
    {
        goalLabel.SetActive(false);
        deathPanel.SetActive(true);
        deathText.SetActive(true);
        buttonDescription.SetActive(true);
        button.SetActive(true);
        tastoImpostazioni.SetActive(true);
        GetComponent<PlayerMovement>().enabled = false;
    }

    //Respawna il player facendolo tornare alla posizione iniziale riattivando il movimento e disattiva i pannelli di morte
    public void Respawn()
    {
        GetComponent<PlayerMovement>().enabled = true;
        button.SetActive(false);
        buttonDescription.SetActive(false);
        deathText.SetActive(false);
        deathPanel.SetActive(false);
        goalLabel.SetActive(true);
        tastoImpostazioni.SetActive(true);
        player.transform.position = new Vector3(-9.96f, 0.09f, 0.0f);
        Debug.Log("Hai respawnato");
    }

    public void TastoImpostazioni()
    {
        Debug.Log("Hai premuto il tasto impostazioni!");
        GetComponent<PlayerMovement>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
