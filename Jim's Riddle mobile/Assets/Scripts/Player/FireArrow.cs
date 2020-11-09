using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class FireArrow : MonoBehaviour
{

    public Rigidbody2D arrowPrefab;
    public float speed;
    public Vector3 velocity;
    public Camera mainCamera;



    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vettoreMovimento = gameObject.GetComponent<PlayerMovement>().vettoreMovimento;//prendo il vettore movimento che fa muovere il player

        if ((Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(1)) && vettoreMovimento != Vector3.zero ) 
        { 
            ArrowPrefabCreation(vettoreMovimento);
        }
    }


    /*Funzione che prende un vettore e restituisce un vettore con parametro Z, pari all'angolo sotteso tra il vettore dato e l'asse X */
    public Vector3 GetArrowRotation(Vector3 vettoreMovimento)
    {
        float angleBeetweenAxis = Vector2.SignedAngle(Vector2.right, vettoreMovimento);
        Vector3 vettoreConRotazione = new Vector3(0, 0, angleBeetweenAxis);

        return vettoreConRotazione;
    }

    /*Funzione che restituisce un float prendendo come riferimento la <size> della telecamera collegata al player*/
    private float StreghtFromCameraSize()
    {
        float floatReturned = speed / 2f;

        if (mainCamera.GetComponent<Camera>().orthographicSize <= 7.09f && mainCamera.GetComponent<Camera>().orthographicSize > 6.524f)
            floatReturned = speed / 2f;
        else if (mainCamera.GetComponent<Camera>().orthographicSize <= 6.558f)
            floatReturned = speed;

        return floatReturned;
            
    }

    /*Crea il prefab della freccia*/
    private void ArrowPrefabCreation(Vector3 vettoreMovimento)
    { 
            /*Creo la freccia da arrowPrefab(prefab), gli do come posizione iniziale quella del player più la normale del vettore movimento del player(vettoreMovimento con modulo = 1), 
             prendo un vettore dalla funzione GetArrowRotation(vettoreMovimento), e lo inserirsco nella rotazione della freccia, quindi la freccia ruota di tot. Z
             Quaternion.Euler alla fine dei giochi è facile da capire, è una versione semplificata di un Quaternion ed è composto da un Vector3 come transform.rotation
             la freccia andrà girata sollo sull'asse Z*/
            Rigidbody2D arrowInstantiated = Instantiate(arrowPrefab, transform.position + vettoreMovimento.normalized, Quaternion.Euler(GetArrowRotation(vettoreMovimento)));
  
   

            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), arrowInstantiated.GetComponent<Collider2D>());
            Physics2D.IgnoreCollision(arrowInstantiated.GetComponent<Collider2D>(), arrowInstantiated.GetComponent<Collider2D>());

            arrowInstantiated.AddForce(vettoreMovimento.normalized * StreghtFromCameraSize() * Time.deltaTime);
            
 
    }
}
