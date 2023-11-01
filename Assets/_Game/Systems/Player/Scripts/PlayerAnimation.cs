using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    [SerializeField] public Animator animator;


    public void SetIdleAnimation() {
        animator.SetBool(Constants.Animation.Booleans.IsIdle,true);
        animator.SetBool(Constants.Animation.Booleans.IsRunning,false);
    }
    public void SetRunningAnimation() {
        animator.SetBool(Constants.Animation.Booleans.IsIdle,false);
        animator.SetBool(Constants.Animation.Booleans.IsRunning,true);
    }
    
}
