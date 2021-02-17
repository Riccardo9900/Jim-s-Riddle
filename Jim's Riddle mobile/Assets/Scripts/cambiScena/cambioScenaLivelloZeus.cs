using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioScenaLivelloZeus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D coll)
    {
        if(coll.tag == "changeScene")
        {
            SceneManager.LoadScene("LabirintoLettere");
        }
        if(coll.tag == "changeSceneAnubi")
        {
            SceneManager.LoadScene("RiccardoAnubiLabirinto");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
