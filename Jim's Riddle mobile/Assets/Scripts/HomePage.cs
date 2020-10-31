using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePage : MonoBehaviour
{
    private Scene scenaHomePage;
    // Start is called before the first frame update
    void Start()
    {
        scenaHomePage = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadHomePage()
    {
        Debug.Log("Sei tornato in home page!");
        SceneManager.LoadScene("Scena iniziale");
        Time.timeScale = 1;
    }
}
