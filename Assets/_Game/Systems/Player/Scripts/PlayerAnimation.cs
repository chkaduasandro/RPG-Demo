using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    [SerializeField] public Animator animator;


    public void SetMovingAnimationSpeed(float multiplier) {
       animator.SetFloat(Constants.Animation.Floats.MoveSpeedMultiplier,multiplier);
    }
    public void SetIdleAnimation() {
        animator.SetBool(Constants.Animation.Booleans.IsIdle,true);
        animator.SetBool(Constants.Animation.Booleans.IsMoving,false);
    }
    public void SetMovingAnimation() {
        animator.SetBool(Constants.Animation.Booleans.IsIdle,false);
        animator.SetBool(Constants.Animation.Booleans.IsMoving,true);
    }
    
}
