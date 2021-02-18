using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDestroy : MonoBehaviour
{
    public GameObject anubi;

    public void DestroyWhenAnubiDied()
    {
        if(anubi==null)
        {
            Destroy(gameObject);
        }
    }

}
