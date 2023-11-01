using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] private NavMeshAgent agent;

    public void SetDestination(Vector3 position) {
        if(NavMesh.SamplePosition(position, out var navHit, 0.1f, NavMesh.AllAreas))
        {
            agent.SetDestination(navHit.position);
        }
    }
}
