using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBarWookong : MonoBehaviour
{
    public GameObject healtBarWookong;
    public Healthbar healtbarWookong;

    // Start is called before the first frame update
    void Start()
    {
        healtBarWookong.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Arrow")
        {
            healtBarWookong.SetActive(true);
        }
    }

    void Update()
    {
        Disattiva();
    }

    public void Disattiva()
    {
        if (healtbarWookong.health <= 0)
        {
            healtBarWookong.SetActive(false);
        }
    }
}
