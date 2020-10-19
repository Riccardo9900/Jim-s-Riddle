using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game gameManager;
    bool gameEnded = false;
    float timePassed;
    [SerializeField]
    public GameObject deathlabel;
    public GameObject deathPanel;


    // Start is called before the first frame update
    void Start()
    {
        timePassed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameEnded)
        {
            timePassed += Time.deltaTime;
        }
    }

    public void isDead()
    {
        gameEnded = true;

    }

    public bool GameEnded()
    {
        return gameEnded;
    }
}
