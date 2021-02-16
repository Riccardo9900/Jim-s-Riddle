using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvantiWookong : MonoBehaviour
{
    public GameObject player;
    public GameObject Wookong;
    private Vector3 WookongPosition; //creato perchè le z sono diverse
    public float speed;
    public GameObject DialogueManager;
    public GameObject CanvasDialoghi;
    // Start is called before the first frame update
    void Start()
    {
        WookongPosition = new Vector3(Wookong.transform.position.x, Wookong.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, WookongPosition, speed * Time.deltaTime);
        if (transform.position == WookongPosition)
        {
            CanvasDialoghi.SetActive(true);
            DialogueManager.SetActive(true);
        }

    }
}
