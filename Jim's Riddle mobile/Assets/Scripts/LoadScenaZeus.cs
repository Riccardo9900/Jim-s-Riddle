using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenaZeus : MonoBehaviour
{
    private Scene scenaZeus;
    // Start is called before the first frame update
    void Start()
    {
        scenaZeus = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadSceneZeus()
    {
        Debug.Log("Hai caricato la scena di Zeus!");
        SceneManager.LoadScene("LivelloZeus");
        Time.timeScale = 1;
    }
}
