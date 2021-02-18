using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimazioneAttaccoWukong : MonoBehaviour
{

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim.SetInteger("ValoreAttacco", 1);
        Invoke("Animazione", 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    void Animazione()
    {
        
    }
}
