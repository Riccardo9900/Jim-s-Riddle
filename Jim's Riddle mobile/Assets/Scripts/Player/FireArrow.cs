﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class FireArrow : MonoBehaviour
{

    public GameObject arrowPrefab;
    public float speed;
    public GameObject player;
    public Vector3 velocity;
    public Camera mainCamera;
    public float tempoInizioFreccia = 0f;   //tempo effettivo da quando viene sparata la freccia (verrà poi incrementato con Time.deltaTime)
    public float tempoDurataFreccia = 2f;   //tempo max della durata della freccia


    void Start()
    {
        tempoInizioFreccia = tempoDurataFreccia;    
    }

    void Update()
    {
        if(tempoDurataFreccia<= tempoInizioFreccia) //controllo se sono passati i secondi necessari per sparare
        {
            //creo il prefab della freccia
            ArrowPrefabCreation();
            //attivo l'animazione dello zoom dello sparo della freccia
            player.GetComponent<PlayerMovement>().arrowFireZoom = true;
        }
        else
        {
            //incremento il tempo 
            tempoInizioFreccia += Time.deltaTime;
            //disattivo l'animazione dello zoom dello sparo della freccia
            player.GetComponent<PlayerMovement>().arrowFireZoom = false;
        }
    
    }


    /*Funzione che prende un vettore e restituisce un vettore con parametro Z, pari all'angolo sotteso tra il vettore dato e l'asse X */
    public Vector3 GetRotation(Vector3 vettoreMovimento)
    {
        float angleBeetweenAxis = Vector2.SignedAngle(Vector2.right, vettoreMovimento);
        Vector3 vettoreConRotazione = new Vector3(0, 0, angleBeetweenAxis);

        return vettoreConRotazione;
    }

    /*Funzione che restituisce un float prendendo come riferimento la <size> della telecamera collegata al player*/
    private float StreghtFromCameraSize()
    {
        float floatReturned = speed;

        if (mainCamera.GetComponent<Camera>().orthographicSize <= 7.09f && mainCamera.GetComponent<Camera>().orthographicSize > 6.724f)
            floatReturned = speed;
        else if (mainCamera.GetComponent<Camera>().orthographicSize <= 6.724f && mainCamera.GetComponent<Camera>().orthographicSize > 6.358f)
            floatReturned = speed * 2;
        else if (mainCamera.GetComponent<Camera>().orthographicSize <= 6.358f)
            floatReturned = speed * 2.5f;

        return floatReturned;
            
    }

    /*Crea il prefab della freccia*/
    private void ArrowPrefabCreation()
    {
        Vector3 vettoreMovimento = gameObject.GetComponent<PlayerMovement>().vettoreMovimento;//prendo il vettore movimento che fa muovere il player

        if ((Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(1)) && vettoreMovimento != Vector3.zero)
        {
            /*Creo la freccia da arrowPrefab(prefab), gli do come posizione iniziale quella del player più la normale del vettore movimento del player(vettoreMovimento con modulo = 1), 
             prendo un vettore dalla funzione GetArrowRotation(vettoreMovimento), e lo inserirsco nella rotazione della freccia, quindi la freccia ruota di tot. Z
             Quaternion.Euler alla fine dei giochi è facile da capire, è una versione semplificata di un Quaternion ed è composto da un Vector3 come transform.rotation
             la freccia andrà girata sollo sull'asse Z*/
            GameObject arrowInstantiated = Instantiate(arrowPrefab, transform.position + vettoreMovimento.normalized, Quaternion.Euler(GetRotation(vettoreMovimento))) as GameObject;
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), arrowInstantiated.GetComponent<Collider2D>());
            arrowInstantiated.GetComponent<Rigidbody2D>().AddForce(vettoreMovimento.normalized * StreghtFromCameraSize() * Time.deltaTime);
            gameObject.GetComponent<Rigidbody2D>().drag = 1f; //rallentalo
            tempoInizioFreccia = 0f; //una volta sparata la freccia resetto il tempo dello sparo

        }
    }
}