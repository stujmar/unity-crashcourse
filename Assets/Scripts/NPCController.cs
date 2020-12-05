using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    public float partrolTime = 10f;
    public float aggroRange = 10f;
    public Transform[] waypoints;

    int index;
    float speed, agentSpeed;
    Transform player;

    Animator anim;
    NavMeshAgent agent;
}
