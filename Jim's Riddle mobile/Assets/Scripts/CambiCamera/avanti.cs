using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanti : MonoBehaviour
{
    public GameObject player;
    public GameObject zeus;
    private Vector3 zeusPosition; //creato perchè le z sono diverse
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        zeusPosition = new Vector3(zeus.transform.position.x, zeus.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, zeusPosition, speed * Time.deltaTime);
        if(transform.position == zeusPosition)
        {
            Invoke("indietro", 2f);
        }

    }

    void indietro()
    {
        gameObject.GetComponent<indietro>().enabled = true;
    }
}
