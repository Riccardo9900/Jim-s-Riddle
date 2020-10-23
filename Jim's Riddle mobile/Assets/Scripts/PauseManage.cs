using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManage : MonoBehaviour
{
    bool isPaused;
    public GameObject pausePanel;
    public GameObject buttonPlay;
    public GameObject buttonReload;
    public GameObject tastoImpostazioni;
    public GameObject tastoPausa;

    // Start is called before the first frame update
    void Start()
    {
        tastoPausa.SetActive(true);
        pausePanel.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Hai messo in pausa!");
            //mi attivi la pausa
            ButtonRiprendi();
        }  
    }

    public void ButtonRiprendi()
    {
        isPaused = !isPaused;
        UpdatePause();
    }

    //Entra in gioco quando viene premuto il tasto pausa:
    //attiva o disattiva tutti gli oggetti della scena
    public void UpdatePause()
    {
        if (isPaused)
        {
            Debug.Log("Hai messo in pausa!");
            //mi blocchi tutti gli oggetti di scena (fermi il tempo)
            Time.timeScale = 0;
            tastoPausa.SetActive(false);
        }
        else
        {
            Debug.Log("Hai premuto play");
            //li attivi (attivi il tempo)
            Time.timeScale = 1;
            tastoPausa.SetActive(true);
        }
        pausePanel.SetActive(isPaused);
        buttonPlay.SetActive(true);
        buttonReload.SetActive(true);
    }
}
