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
        if(coll.tag == "changeSceneTutorial")
        {
            SceneManager.LoadScene("TutorialLabirinto");
        }
        if (coll.tag == "changeSceneTutorial2")
        {
            SceneManager.LoadScene("Riccardo");
        }
        if (coll.tag == "changeScene")
        {
            SceneManager.LoadScene("LabirintoLettere");
        }
        if (coll.tag == "changeScene1")
        {
            SceneManager.LoadScene("FrancescoAnubi");
        }
        if (coll.tag == "changeSceneAnubi")
        {
            SceneManager.LoadScene("RiccardoAnubiLabirinto");
        }
        if (coll.tag == "changeSceneAnubi2")
        {
            SceneManager.LoadScene("RiccardoWookong");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
