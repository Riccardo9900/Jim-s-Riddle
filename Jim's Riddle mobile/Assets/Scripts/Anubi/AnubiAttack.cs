using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnubiAttack : MonoBehaviour
{
    public Healthbar healtBarAnubi;
    public GameObject scheletroPrefab, miniBossPrefab;
    public GameObject spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4, spawnPoint5;
    public HealthbarPlayer healthBarPlayer;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {

    }
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Arrow")
        {
            CreaNemico();
        }
    }

    public void CreaNemico()
    {
        
        if (healthBarPlayer.health > 0)
        {
            if (healtBarAnubi.health >= 90 && healtBarAnubi.health < 100)
            {
                animazioneS();
                PrimiScheletri();
                
            }
            if (healtBarAnubi.health >= 80 && healtBarAnubi.health < 90)
            {
                animazioneS();
                Instantiate(scheletroPrefab, spawnPoint1.transform);
                Instantiate(scheletroPrefab, spawnPoint2.transform);
                animazioneM();
                Instantiate(miniBossPrefab, spawnPoint5.transform);
            }
            if (healtBarAnubi.health >= 70 && healtBarAnubi.health < 80)
            {
                animazioneS();

                Instantiate(scheletroPrefab, spawnPoint3.transform);

                Instantiate(scheletroPrefab, spawnPoint2.transform);

                Instantiate(scheletroPrefab, spawnPoint1.transform);

            }
            if (healtBarAnubi.health <= 60)
            {
                animazioneM();
                
                Instantiate(miniBossPrefab, spawnPoint5.transform);
                animazioneS();
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

    public void PrimiScheletri()
    {
        Instantiate(scheletroPrefab, spawnPoint1.transform);
        Instantiate(scheletroPrefab, spawnPoint2.transform);
    }

    public void animazioneS()
    {
        anim.SetBool("Skeleton", true);
        Invoke("AnimazioneUnoS", 1.5f);
    }
    public void AnimazioneUnoS()
    {
        anim.SetBool("Skeleton", false);
    }

    public void animazioneM()
    {
        anim.SetBool("MiniBoss", true);
        Invoke("AnimazioneUnoM", 3f);
    }
    public void AnimazioneUnoM()
    {
        anim.SetBool("MiniBoss", false);
    }

}
