using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField]
    public GameObject DeathPanel;
    public GameObject DeathText;
    public int healt = 0;

    // Start is called before the first frame update
    void Start()
    {
        DeathPanel.SetActive(false);
        DeathText.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "DeathCube")
        {
            Debug.Log("Hai preso il cubo sbagliato");
            DeathPanel.SetActive(true);
            DeathText.SetActive(true);
        }
    }


   // public void isHit()
   //{
   //     if (healt == 0)
   //     {
   //        Game.gameManager.isDead();
   //         DeathPanel.SetActive(true);
   //     }
   // }

    // Update is called once per frame
    void Update()
    {

    }
}
