using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityCamera : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    { 
        LookPlayer();   
    }

    private void LookPlayer()
    {
        transform.LookAt(player);
    }
}
