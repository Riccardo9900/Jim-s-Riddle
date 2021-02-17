using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WookongAttack : MonoBehaviour
{
    Transform target;
    private Vector3 posizioneIniziale;
    public GameObject wookong;
    public GameObject mainCamera;
    public float velocitaWookong;
    public float tempoDaInizio = 0f;
    public float tempoInseguimento = 0f;

    // Start is called before the first frame update
    void Start()
    {
        posizioneIniziale = new Vector3(wookong.transform.position.x, wookong.transform.position.y, 0.0f);
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void TornaInPosizioneIniziale()
    {
        transform.position = Vector2.MoveTowards(transform.position, posizioneIniziale, Time.deltaTime * velocitaWookong);
    }

    public void Inseguimento()
    {
        var dir = target.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime * velocitaWookong);
    }

    // Update is called once per frame
    void Update()
    {
       if(tempoDaInizio<=tempoInseguimento)
        {
            //animazione inseguimento

            Inseguimento();
            tempoDaInizio += Time.deltaTime;
        }
       else
        {
            //animazione torna indietro

            TornaInPosizioneIniziale();
            if(transform.position == posizioneIniziale)
            {
                Invoke("TempoDaInizio", 1.5f);
            }
        }
    }

    public void TempoDaInizio()
    {
        tempoDaInizio = 0f;
    }
            
        
}
