using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class FireArrow : MonoBehaviour
{

    public GameObject arrowPrefab;
    public float speed;
    public Vector3 velocity;
    public Camera mainCamera;
    public GameObject player;
    public float tempoFreccia = 2f;
    public float tempoDaInizioSparo = 0f;


    void Start()
    {
        tempoDaInizioSparo = tempoFreccia;
    }

    void Update()
    {
        if (tempoFreccia <= tempoDaInizioSparo)
        {
            ArrowPrefabCreation();
        }
        else
        {
            player.GetComponent<PlayerMovement>().arrowMotionZoom = false;
            tempoDaInizioSparo += Time.deltaTime;
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
        float floatReturned = speed / 3f;

        if (mainCamera.GetComponent<Camera>().orthographicSize <= 7.09f && mainCamera.GetComponent<Camera>().orthographicSize > 6.724f)
            floatReturned = speed / 3f;
        else if (mainCamera.GetComponent<Camera>().orthographicSize <= 6.724f && mainCamera.GetComponent<Camera>().orthographicSize > 6.358f)
            floatReturned = speed / 2f;
        else if (mainCamera.GetComponent<Camera>().orthographicSize <= 6.358f)
            floatReturned = speed;

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
            tempoDaInizioSparo = 0f;

        }
    }
}
