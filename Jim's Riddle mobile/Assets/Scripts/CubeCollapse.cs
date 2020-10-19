using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollapse : MonoBehaviour
{

    [SerializeField]
    public GameObject deathPanel;
    public GameObject deathLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void OnTriggerEnter(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Hai preso il player");
        }
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
