using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField]
    public GameObject DeathPanel;
    public int healt = 0;

    // Start is called before the first frame update
    void Start()
    {
        DeathPanel.SetActive(false);
    }

    public void isHit()
    {
        if (healt == 0)
        {
            Game.gameManager.isDead();
            DeathPanel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
