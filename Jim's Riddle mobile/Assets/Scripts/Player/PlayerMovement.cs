using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick; //Inserisco joystick
    public Animator playerAnimation;
    public float movementIncrease; //aumenta la velocità di movimento
    public Vector3 vettoreMovimento; // è il vettore movimento che verrà applicato al movimento del giocatore sui due assi
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>(); //Cerca il joystick negli oggetti
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        
        if (joystick.Horizontal != 0 || joystick.Vertical != 0) //Se le coordinate del joystick sono diverse da zero si sta usando il joystick.
        {
            this.vettoreMovimento = new Vector3(joystick.Horizontal, joystick.Vertical, 0.0f); //Prendo le coordinate del joystick nel vettore movimento.
        }
        else //Altrimenti sto usando la tastiera
        {
            this.vettoreMovimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f); //Prendo le coordinate della tastiera nel vettore movimento.
        }


        //Parte delle animazioni del giocatore
        //Horizontal Vertical e Magnitude sono stringhe preimpostate da Unity come int id
        if (vettoreMovimento != Vector3.zero)//sto dicendo che se il vettore non è (0;0) allora fai partire le animazioni
        {
            
            playerAnimation.SetFloat("Horizontal", vettoreMovimento.x);
            playerAnimation.SetFloat("Vertical", vettoreMovimento.y);
        }
        playerAnimation.SetFloat("Magnitude", vettoreMovimento.magnitude);//magnitude è la "potenza" con cui viene premuto il tasto, o meglio la lunghezza del vettore (modulo)


        //la variabile movement increase è in caso di necessità nel caso serva aumentare momentaneamente/permanentemente la velocità del giocatore
        //Time.deltaTime serve per gli FPS
        transform.position += vettoreMovimento * movementIncrease * Time.deltaTime;



    }
}
