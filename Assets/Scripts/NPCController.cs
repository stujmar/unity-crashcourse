using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    public float partrolTime = 10f;
    public float aggroRange = 10f;
    public Transform[] waypoints;

    // Default accessor is private;
    private int index;
    private float speed, agentSpeed;
    private Transform player;

    private Animator anim;
    private NavMeshAgent agent;

    private void Awake()
    {
        
    }
}
