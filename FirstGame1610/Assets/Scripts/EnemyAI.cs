﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform Player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {
        agent.destination = Player.position;
    }
    
}
