using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    public CameraController CameraController;
    public PlayerMovement playerMovement;
    public PlayerAnimation playerAnimation;


    [SerializeField] private LayerMask groundLayer;
    void Update() {
        Process_Movement();
        Process_Animation();
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

    private void Process_Animation() {
        if (playerMovement.isMoving) {
            playerAnimation.SetMovingAnimation();
            // playerAnimation.SetMovingAnimationSpeed(playerMovement.agentSpeedMultiplier);
        }
        else playerAnimation.SetIdleAnimation();
    }
}
