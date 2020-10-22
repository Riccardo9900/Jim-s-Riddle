using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManage : MonoBehaviour
{
    bool isPaused;
    public GameObject pausePanel;
    public GameObject buttonPlay;
    public GameObject buttonReload;

    // Start is called before the first frame update
    void Start()
    {
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
            //mi blocchi tutti gli oggetti di scena (fermi il tempo)
            Time.timeScale = 0;
        }
        else
        {
            //li attivi (attivi il tempo)
            Time.timeScale = 1;
        }
        pausePanel.SetActive(isPaused);
        buttonPlay.SetActive(true);
        buttonReload.SetActive(true);
    }
}
