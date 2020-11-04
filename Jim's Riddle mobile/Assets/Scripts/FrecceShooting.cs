using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrecceShooting : MonoBehaviour
{
    public GameObject player;
    public float tempoDaUltimoLancio = 1f;
    public float tempoTraColpi = 2f;
    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        tempoDaUltimoLancio = tempoTraColpi;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tempoDaUltimoLancio >= tempoTraColpi)
        {
            Debug.Log("Hai lanciato la freccia!");
            LancioFrecce();
        }
        if (tempoDaUltimoLancio <= tempoTraColpi)
        {
            tempoDaUltimoLancio += Time.deltaTime;
        }

    }

    public void LancioFrecce()
    {
        if(tempoDaUltimoLancio>= tempoTraColpi)
        {
            //Spawno l'oggetto freccia presente in Asset/Resources ogni volta che premo il tasto 'space'
            GameObject freccia = (GameObject)Instantiate(Resources.Load("Freccia"), player.transform.position, transform.rotation);
            tempoDaUltimoLancio = 0f;  
        }
        
    }
}
