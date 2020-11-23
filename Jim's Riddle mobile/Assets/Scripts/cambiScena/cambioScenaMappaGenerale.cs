using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioScenaMappaGenerale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void VaiAMapaIniziale()
    {
        SceneManager.LoadScene("Mappa Generale");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
