using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackWookong : MonoBehaviour
{
    public float KnockbackPower;
    public float KnockbackDuration;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Player")
        {
            StartCoroutine(Knockback.istance.KnockbackMetodo(KnockbackDuration, KnockbackPower, this.transform));
        }
    }

}
