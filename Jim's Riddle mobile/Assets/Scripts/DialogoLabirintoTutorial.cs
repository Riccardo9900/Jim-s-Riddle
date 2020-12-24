using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogoLabirintoTutorial : MonoBehaviour
{
    //display testo
    public TextMeshProUGUI textDisplay;

    //Lettere tutorial
    public string[] frasi;
    public float velocitascorrimento;
    private int index;

    public GameObject tastoContinua;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Scorrimento());
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
        index++;
        if (index < frasi.Length - 1)
        {
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
       if(index == 0)
        {
            return primaFrase();
        }

        return true;
    }


    bool primaFrase()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().enabled = true;
        if(GameObject.FindGameObjectWithTag("PortaFine").GetComponent<Animator>().enabled == true)
        {
            return true;
        }
        return false;
    }


}
