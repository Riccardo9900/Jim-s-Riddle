using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestioneSuoni : MonoBehaviour
{
    public AudioSource passi;
    public Vector3 vettoreMovimento;
    public Joystick joystick;

    void Start() 
    {


    }

    public void AttivazionePassi()
    {
        passi.Play();
    }
}
