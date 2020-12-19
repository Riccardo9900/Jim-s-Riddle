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
        else
            return true;
    }

    bool movimentoVerificato()
    {
        if (posizioneIniziale == GameObject.FindGameObjectWithTag("Player").transform.position)

            return false;
        else
       
            return true;
    }
}
