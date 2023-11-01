using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    public CameraController CameraController;
    public PlayerMovement playerMovement;


    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private NavMeshAgent navAgent;
    
    
    void Update() {
        Process_Movement();
    }

    private void Process_Movement() {
        if (Input.GetMouseButtonDown(0))
        {
            Ray        ray = CameraController.mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit,100f,groundLayer))
            {
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue, 1.0f);
                if (hit.collider != null)
                {
                    Vector3 clickPoint = hit.point;
                    playerMovement.SetDestination(clickPoint);
                }
            }
        }
    }
}
