using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public HealthbarPlayer healthBarScript;
    public GameObject healtBarPlayer;
    public float dannoScheletro;
    public float dannoFulmine;
    public float tempoDaQuandoSeiPreso = 0f;
    public float currentHealth;
    public AudioSource sottofondoMusicale;
    public AudioSource audioDamage;

    // Start is called before the first frame update
    void Start()
    {
        sottofondoMusicale.Play();
        GestioneBarra();
        currentHealth = healthBarScript.health;
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Scheletro")
        {
            audioDamage.Play();
            GestioneBarra();
            healthBarScript.health = healthBarScript.health - dannoScheletro;
        }
        if(coll.tag == "Fulmine")
        {
            audioDamage.Play();
            GestioneBarra();
            healthBarScript.health = healthBarScript.health - dannoFulmine;
        }

        Debug.Log("Hai " + (healthBarScript.health) / 10f + " vite");
        currentHealth = healthBarScript.health;
    }

    public void GestioneBarra()
    {
        healtBarPlayer.SetActive(true);
        Invoke("DisattivaBarra", 2.5f);  //Disattiva la healtBarPlayer dopo 2,5 secondi
    }

   public void DisattivaBarra()
    {
        healtBarPlayer.SetActive(false);
    }

    public void Morte()
    {
        if(currentHealth <= 0)
        {
            audioDamage.Stop();
            sottofondoMusicale.Stop();
            GetComponent<PlayerDamage>().Death();

            //Da disattivare il metodo 'sparaFumine' di ZeusAttack (perché il piccolo programmatore Riccardo non l'ha fatto)
            //GetComponent<ZeusAttack>().sparaFulmine().enabled = false;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 1)
        {
            Morte();
        }
    }
}
