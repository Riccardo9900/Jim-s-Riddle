using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D player;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < 9 &&
            Vector3.Distance(transform.position, player.position) > 5.5)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        }
    }
}