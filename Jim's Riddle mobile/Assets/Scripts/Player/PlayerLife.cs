using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public HealthbarPlayer healthBarScript;
    public GameObject healtBarPlayer;
    public float dannoScheletro;
    public float tempoDaQuandoSeiPreso = 0f;

    // Start is called before the first frame update
    void Start()
    {
        healtBarPlayer.SetActive(true);
        dannoScheletro = 10;
    }

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Scheletro")
        {
            tempoDaQuandoSeiPreso = 0f;
            healtBarPlayer.SetActive(true);
            healthBarScript.health = healthBarScript.health - dannoScheletro;
            Debug.Log(healthBarScript.health);
        }
    }

    public void UpdateTime()
    {
        tempoDaQuandoSeiPreso += Time.deltaTime;
        if (tempoDaQuandoSeiPreso >= 2.5f)
        {
            healtBarPlayer.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
        if(healthBarScript.health <= 0)
        {
            GetComponent<PlayerDamage>().Death();
        }
    }
}
