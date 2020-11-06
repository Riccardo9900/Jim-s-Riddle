using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusMovement : MonoBehaviour
{
    public float speed; //velocità movimento zeus
    public Rigidbody2D player; //si dirige verso il player


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < 10 &&
            Vector3.Distance(transform.position, player.position) > 5.5 &&
            transform.position.y >= -3.7)  //se la distanza tra zeus e il player è minore di 9 e maggiore di 5.5 zeus rincorre il player
                                                                          //cosi non si avvicina troppo e si dirige solo quando "rileva" il player.
                                                                          //Non continua ad andare se il player si rifugia nel sentiero
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime); //Funzione da un vettore di partenza che insegue un altro vettore

        }
    }
}