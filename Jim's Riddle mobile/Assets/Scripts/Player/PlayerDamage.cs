using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField]
    public GameObject deathPanel;
    public GameObject deathText;
    public GameObject buttonDescription;
    public GameObject button;
    public GameObject player;
    public GameObject toDestroy;

    // Start is called before the first frame update
    void Start()
    {
        deathPanel.SetActive(false);
        deathText.SetActive(false);
        buttonDescription.SetActive(false);
        button.SetActive(false);
    }

    //Vede se faccio ua collisione con un oggetto nemico (in questo caso con il cubo rosso con il tag DeathCube) e lo distrugge. 
    //Disattiva il movimento del player bloccando ogni input da tastiera e attiva i pannelli di morte (bottone, pannello e scritta)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathCube")
        {
            Debug.Log("Hai preso il cubo sbagliato");
            Destroy(toDestroy);
            deathPanel.SetActive(true);
            deathText.SetActive(true);
            buttonDescription.SetActive(true);
            button.SetActive(true);
            GetComponent<PlayerMovement>().enabled = false;
            Cursor.visible = true;
        }
    }


    //Respawna il player facendolo tornare alla posizione iniziale riattivando il movimento e disattiva i pannelli di morte
    public void Respawn()
    {
        GetComponent<PlayerMovement>().enabled = true;
        button.SetActive(false);
        buttonDescription.SetActive(false);
        deathText.SetActive(false);
        deathPanel.SetActive(false);
        player.transform.position = new Vector3(-9.96f, 0.09f, 0.0f);
        Debug.Log("Hai respawnato");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
