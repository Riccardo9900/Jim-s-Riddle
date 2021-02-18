using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    public static Knockback istance;

    private Rigidbody2D rb;
    
    
    void Awake()
    {
        istance = this;
    }
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    public IEnumerator KnockbackMetodo(float knockbackDuration, float knockbackPower, Transform obj)
    {
        float timer = 0;

        while (knockbackDuration > timer)
        {
            timer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - this.transform.position).normalized;
            rb.AddForce(-direction * knockbackPower);
        }
        yield return 0;
    }
}
