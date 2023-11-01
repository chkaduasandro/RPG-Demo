using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform target;                      // Player's transform
	public Vector3 offset = new Vector3(0,15,-4); // Offset from the player

	void LateUpdate() {
		if (target != null) {
			Vector3 desiredPosition = target.position + offset;
			transform.position = desiredPosition;
			transform.LookAt(target.position);
		}
	}
}