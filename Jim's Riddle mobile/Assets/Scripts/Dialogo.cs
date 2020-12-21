using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    //display testo
    public TextMeshProUGUI textDisplay;
    
    //Lettere tutorial
    public string[] frasi;
    public float velocitascorrimento;
    private int index;

    //Oggetti che compaiono durante il tutorial
    public GameObject CanvasHealthBarBoss;
    public GameObject canvasPausa;
    public GameObject tastoContinua;    
    public GameObject sfondoJoystick;
    public GameObject frecciaTutorial1;

    //Camera
    public Camera mainCamera;

    //oggetti per l'avanzamento del tutorial
    private Vector3 posizioneIniziale;
    public Healthbar Healthbarboss;
    public GameObject boss;

    void Start()
    {
        StartCoroutine(Scorrimento());
        posizioneIniziale = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
    //Con Questo metodo faccio scorrere le lettere con una velocità decisa da me
    IEnumerator Scorrimento()
    {
        foreach (char lettera in frasi[index].ToCharArray())
        {
            textDisplay.text += lettera; //scorro il display
            yield return new WaitForSeconds(velocitascorrimento); //Creo collezione enumerabile
        }
    }

    public void FraseSuccessiva()
    {
        tastoContinua.SetActive(false);

        if(index < frasi.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Scorrimento());
        }
        else
        {
            textDisplay.text = "";
            tastoContinua.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (textDisplay.text == frasi[index])

            tastoContinua.SetActive(settaggioContinua());
    }

    bool settaggioContinua()
    {
        if (index == 2)
        {
            return movimentoVerificato();
        }
        if(index == 3)
        {
            return contattoConPorta();
        }

        if(index == 5)
        {
            return fineMovimentoCamera();
        }

        if(index == 8)
        {
            return bossColpito();
        }

        if(index == 9)
        {
            return bossMorto();
        }
            
        else
            return true;
    }

    bool bossMorto()
    {
        if(boss == null)
        {
            return true;
        }
        return false;
    }
    bool bossColpito()
    {
        canvasPausa.SetActive(true);
        boss.GetComponent<ZeusLife>().enabled = true;
        boss.GetComponent<ZeusDeath>().enabled = true;
        if(Healthbarboss.health != 100)
        {
            return true;
        }
        return false;
    }

    bool fineMovimentoCamera()
    {
        if (mainCamera.GetComponent<indietro>().enabled == true)
        {
            CanvasHealthBarBoss.SetActive(true);
        }
        if (GameObject.FindGameObjectWithTag("portaInizio") != null)
        {
            return false;
        }
        return true;
    }



    bool contattoConPorta()
    {
        if(GameObject.FindGameObjectWithTag("Porta").GetComponent<Animator>().enabled == true)
        {
            return true;
        }
        return false;
    }

    bool movimentoVerificato()
    {
        sfondoJoystick.SetActive(true);
        frecciaTutorial1.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        if (posizioneIniziale == GameObject.FindGameObjectWithTag("Player").transform.position)

            return false;
        else
        {

            frecciaTutorial1.SetActive(false);
            return true;
        }
    }
}
