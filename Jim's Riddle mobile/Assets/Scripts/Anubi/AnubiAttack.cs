using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnubiAttack : MonoBehaviour
{
    public Healthbar healtBarAnubi;
    public GameObject scheletroPrefab;
    public GameObject spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4;
    public HealthbarPlayer healthBarPlayer;


    // Start is called before the first frame update
    void Start()
    {

    }
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Arrow")
        {
            CreaScheletro();
        }
    }

    public void CreaScheletro()
    {
        if (healthBarPlayer.health > 0)
        {
            if (healtBarAnubi.health >= 90 && healtBarAnubi.health < 100)
            {
                Instantiate(scheletroPrefab, spawnPoint1.transform);
            }
            if (healtBarAnubi.health >= 80 && healtBarAnubi.health < 90)
            {

                Instantiate(scheletroPrefab, spawnPoint2.transform);

            }
            if (healtBarAnubi.health >= 70 && healtBarAnubi.health < 80)
            {

                Instantiate(scheletroPrefab, spawnPoint3.transform);

                Instantiate(scheletroPrefab, spawnPoint2.transform);

                Instantiate(scheletroPrefab, spawnPoint1.transform);

            }
            if (healtBarAnubi.health <= 60)
            {

                Instantiate(scheletroPrefab, spawnPoint4.transform);

                Instantiate(scheletroPrefab, spawnPoint3.transform);

                Instantiate(scheletroPrefab, spawnPoint2.transform);

                Instantiate(scheletroPrefab, spawnPoint1.transform);

            }
        }
        else
            if (healtBarAnubi.health <= 0)
        {
            Destroy(healtBarAnubi);
        }
      
    }


}
