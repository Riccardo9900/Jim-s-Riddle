using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public float newZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vettore = new Vector3(0.0f, 0.0f, newZ);
        gameObject.transform.position = player.position + vettore;
    }
}
