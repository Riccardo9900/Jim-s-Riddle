using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithFloor : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        this.canvas.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Pavimento Sbagliato")
        {
            this.canvas.SetActive(true);
            GetComponent<PlayerMovement>().enabled = false;

        }
    }

    public void Respawn ()
    {
        GetComponent<PlayerMovement>().enabled = true;
        this.canvas.SetActive(false);
        gameObject.transform.position = new Vector3(0f, -9.2f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
