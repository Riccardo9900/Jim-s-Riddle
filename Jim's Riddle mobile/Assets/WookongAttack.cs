using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WookongAttack : MonoBehaviour
{
    Transform target;
    public Healthbar healthBarScript;
    private Vector3 posizioneIniziale;
    public GameObject wookong;
    public GameObject mainCamera;
    public float velocitaWookong;
    public float tempoDaInizio = 0f;
    public float tempoInseguimento = 0f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        healthBarScript.enabled = true;
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
        gameObject.GetComponent<AnimazioneAttaccoWukong>().enabled = true;
        if (tempoDaInizio<=tempoInseguimento)
        {
            

            Inseguimento();
            tempoDaInizio += Time.deltaTime;
        }
       else
        {

            TornaInPosizioneIniziale();
            if(transform.position == posizioneIniziale)
            {
                
                gameObject.GetComponent<AnimazioneAttaccoWukong>().enabled = false;
                Invoke("TempoDaInizio", 1.5f);
            }
        }
    }

    public void TempoDaInizio()
    {
        tempoDaInizio = 0f;
    }
}
