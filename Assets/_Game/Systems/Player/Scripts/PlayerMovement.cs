using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private NavMeshAgent agent;
    
    public bool isMoving => !ReachedDestination();
    public void SetDestination(Vector3 position) {
        if(NavMesh.SamplePosition(position, out var navHit, 0.1f, NavMesh.AllAreas))
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
