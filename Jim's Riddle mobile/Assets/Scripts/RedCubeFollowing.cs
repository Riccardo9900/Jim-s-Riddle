﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Player;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.SceneManagement;

public class RedCubeFollowing : MonoBehaviour
{
    Transform target;
    [SerializeField]
    public float CubeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    //Il cubo insegue il Player tramite la sua posizione
    void Following()
    {
        //uso var per avere lo stesso tipo di ciò che ho alla destra dell'uguale
        var dir = target.position - transform.position;
        //per fare in modo che il cubo ruoti in base alla posizione del personaggio
        var angle = Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.position = Vector2.MoveTowards(transform.position, target.position, Time.deltaTime * CubeSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Following();
    }
}
