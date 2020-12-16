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
                GameObject scheletroInstantiated1 = Instantiate(scheletroPrefab, spawnPoint1.transform);
            }
            if (healtBarAnubi.health >= 80 && healtBarAnubi.health < 90)
            {

                GameObject scheletroInstantiated2 = Instantiate(scheletroPrefab, spawnPoint2.transform);

            }
            if (healtBarAnubi.health >= 70 && healtBarAnubi.health < 80)
            {

                GameObject scheletroInstantiated3 = Instantiate(scheletroPrefab, spawnPoint3.transform);

                GameObject scheletroInstantiated2 = Instantiate(scheletroPrefab, spawnPoint2.transform);

                GameObject scheletroInstantiated1 = Instantiate(scheletroPrefab, spawnPoint1.transform);

            }
            if (healtBarAnubi.health <= 60)
            {

                GameObject scheletroInstantiated4 = Instantiate(scheletroPrefab, spawnPoint4.transform);

                GameObject scheletroInstantiated3 = Instantiate(scheletroPrefab, spawnPoint3.transform);

                GameObject scheletroInstantiated2 = Instantiate(scheletroPrefab, spawnPoint2.transform);

                GameObject scheletroInstantiated1 = Instantiate(scheletroPrefab, spawnPoint1.transform);

            }
        }
      
    }


}
