using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Camera mainCamera;
	
	[SerializeField] private Transform target;                      // Player's transform
	[SerializeField] private Vector3 offset = new Vector3(0,15,-4); // Offset from the player


	private void Awake() {
		mainCamera = GetComponent<Camera>();
	}

	void LateUpdate() {
		if (target != null) {
			Vector3 desiredPosition = target.position + offset;
			transform.position = desiredPosition;
			transform.LookAt(target.position);
		}
	}
}