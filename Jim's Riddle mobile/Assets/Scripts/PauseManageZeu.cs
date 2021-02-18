﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseManageZeu : MonoBehaviour
{
    bool isPaused;
    public GameObject pausePanel;
    public GameObject buttonReload;
    public GameObject tastoPausa;
    public Canvas canvasJoystick;
    private Scene scenaCorrente;
    public AudioSource sottofondoMusicale;
    public GameObject healthbarZeus;
    // Start is called before the first frame update
    void Start()
    {
        scenaCorrente = SceneManager.GetActiveScene();
        tastoPausa.SetActive(true);
        pausePanel.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
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
            healthbarZeus.SetActive(false);
            canvasJoystick.enabled = false;
            sottofondoMusicale.Pause();
        }
        else
        {
            Debug.Log("Hai premuto play");
            //li attivi (attivi il tempo)
            Time.timeScale = 1;
            tastoPausa.SetActive(true);
            healthbarZeus.SetActive(true);
            canvasJoystick.enabled = true;
            sottofondoMusicale.Play();

        }
        pausePanel.SetActive(isPaused);
        buttonReload.SetActive(true);
    }

    //Mi ricarica la scena corrente:
    //Entra in gioco quando viene premuto il tasto con la freccia che va indietro dopo che il Player è morto
    public void ReloadScene()
    {
        Debug.Log("Hai ricaricato la scena!");
        SceneManager.LoadScene(scenaCorrente.name);
        Time.timeScale = 1;
    }
}
