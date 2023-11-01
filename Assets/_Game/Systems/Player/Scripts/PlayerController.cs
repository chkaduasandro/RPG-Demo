using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    public CameraController CameraController;
    public PlayerMovement PlayerMovement;


    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private NavMeshAgent navAgent;
    
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse click
        {
            Ray        ray = CameraController.mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit,100f,groundLayer))
            {
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue, 1.0f);
                if (hit.collider != null)
                {
                    Vector3 clickPoint = hit.point;
                    if(NavMesh.SamplePosition(clickPoint, out var navHit, 0.1f, NavMesh.AllAreas))
                    {
                        navAgent.SetDestination(navHit.position);
                    }
                }
            }
        }
    }
}
