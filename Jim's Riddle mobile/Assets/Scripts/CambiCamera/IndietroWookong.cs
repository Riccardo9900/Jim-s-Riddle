using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndietroWookong : MonoBehaviour
{
    public GameObject player;
    public GameObject wookong;
    private Vector3 playerPosition;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
        gameObject.GetComponent<AvantiWookong>().enabled = false;
        playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        if (transform.position == playerPosition)
        {
            gameObject.GetComponent<ristoroFunzioniWookong>().enabled = true;
        }
    }
}
