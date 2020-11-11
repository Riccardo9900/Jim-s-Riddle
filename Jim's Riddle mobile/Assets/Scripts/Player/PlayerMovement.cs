using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick; //Inserisco joystick
    public Animator playerAnimation;
    public bool arrowMotionZoom = true;
    public float movementIncrease; //aumenta la velocità di movimento
    public Vector3 vettoreMovimento; // è il vettore movimento che verrà applicato al movimento del giocatore sui due assi
    public GameObject mainCamera;
    public GameObject arrow;

    
    void Start()
    {
        joystick = FindObjectOfType<Joystick>(); //Cerca il joystick negli oggetti
    }


    void FixedUpdate()
    {
        MovementAndAnimation();
        ArrowFireMotion();
    }

    void OnTriggerEnter2D (Collider2D coll)
    {
        if (coll.tag == "changeScene")
        {
            SceneManager.LoadScene("LabirintoLettere");
        }
    }

    /*Movimento ed animazione del player*/
    public void MovementAndAnimation()
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
        GetComponent<Rigidbody2D>().velocity = vettoreMovimento * movementIncrease * Time.deltaTime;
    }

    /*Come sparare la freccia e cosa succede quando viene cliccato il pulsante Space o MouseDx*/
    public void ArrowFireMotion()
    {
        if (arrowMotionZoom)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(1))
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;//Imposto la velocità del player uguale a zero
                                                                    //animazione attacco da inserire

                //se la size è maggiore di 6 allora diminuiscila di 0.02 ogni frame
                if (mainCamera.GetComponent<Camera>().orthographicSize > 6f)
                {
                    mainCamera.GetComponent<Camera>().orthographicSize -= 0.12f;
                }
            }
            //sennò se ancora di dimensione minore di 7.09 ingrandiscila ogni frame di 0.3
            else
            if (mainCamera.GetComponent<Camera>().orthographicSize < 7.09f)
                mainCamera.GetComponent<Camera>().orthographicSize += 0.3f;
        }
        return;
    }



}
