using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemybehaviour : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform player;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(player.position);
    }
}
