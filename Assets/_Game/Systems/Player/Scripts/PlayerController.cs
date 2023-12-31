using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    public CameraController CameraController;
    public PlayerMovement PlayerMovement;
    public PlayerAnimation PlayerAnimation;
    void Update() {
        Process_Input();
        Process_Animation();
    }

    private void Process_Input() {
        if (Input.GetMouseButtonDown(0))
        {
            Ray        ray = CameraController.mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue, 1.0f);
                if (hit.collider == null) return;

                if (hit.collider.CompareTag(Constants.Tags.Ground)) {
                    Vector3 clickPoint = hit.point;
                    PlayerMovement.SetDestination(clickPoint);
                }
                else if (hit.collider.CompareTag(Constants.Tags.Interactable)) {
                    var interactable = hit.collider.GetComponent<IInteractable>();
                    interactable.Interact();
                }
            }
        }
    }
    
    private void Process_Animation() {
        if (PlayerMovement.isMoving) {
            PlayerAnimation.SetMovingAnimation();
            // playerAnimation.SetMovingAnimationSpeed(playerMovement.agentSpeedMultiplier);
        }
        else PlayerAnimation.SetIdleAnimation();
    }
}
