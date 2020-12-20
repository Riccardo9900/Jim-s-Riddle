using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] frasi;
    public float velocitascorrimento;
    private int index;
    public GameObject tastoContinua;
    private Vector3 posizioneIniziale;
    public GameObject sfondoJoystick;

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
            
        else
            return true;
    }

    bool fineMovimentoCamera()
    {
        if(GameObject.FindGameObjectWithTag("portaInizio") != null)
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
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        if (posizioneIniziale == GameObject.FindGameObjectWithTag("Player").transform.position)

            return false;
        else
       
            return true;
    }
}
