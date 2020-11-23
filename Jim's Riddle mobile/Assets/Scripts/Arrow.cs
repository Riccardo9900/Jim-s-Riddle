using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject player;
    public GameObject Arrow1;
    public GameObject fulmine;
    public Animator animator;

    void Start()
    {
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), Arrow1.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), fulmine.GetComponent<Collider2D>());
    }


    // Update is called once per frame
    void Update()
    {      

    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Arrow")
        {
            return;
        }
            animator.SetBool("isColliding", true);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(gameObject, 1f);
    }


}
