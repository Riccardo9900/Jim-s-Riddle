using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject player;
    public float destroyTimer;

    public Animator animator;

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
           
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Collider"))
        {
            animator.SetBool("isColliding", true);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(gameObject, 5f);
        }

        else
            Destroy(gameObject, 1f);
    }


}
