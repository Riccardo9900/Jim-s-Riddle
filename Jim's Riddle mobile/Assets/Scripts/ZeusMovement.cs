using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeusMovement : MonoBehaviour
{
    public Rigidbody2D player;
    public float movementIncrease;
    private Vector3 vettoreMovimento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) < 4 ) {
            vettoreMovimento = new Vector3(1, 1, 0.0f) ;
            transform.position = Vector3.MoveTowards((transform.position+=vettoreMovimento), player.transform.position, movementIncrease * Time.deltaTime);


        }
    }
}
