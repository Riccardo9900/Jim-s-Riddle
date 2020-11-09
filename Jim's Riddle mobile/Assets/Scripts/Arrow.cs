using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public GameObject player;

    public Animator animator;

    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {


    }

     void Awake()
    {
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
            animator.SetBool("isColliding", true);
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Destroy(gameObject, 5f);
            Debug.Log("Collisiom");



    }


}
