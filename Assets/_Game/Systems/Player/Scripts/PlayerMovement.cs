using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private NavMeshAgent agent;

    public bool isMoving => !ReachedDestination();
    public float agentSpeed => agent.velocity.magnitude;
    public float agentSpeedNormalized => agent.velocity.magnitude / agent.speed;

    public void SetDestination(Vector3 position) {
        if(NavMesh.SamplePosition(position, out var navHit, 1f, NavMesh.AllAreas))
        {
            agent.SetDestination(navHit.position);
        }
    }
    

    public bool ReachedDestination() {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
