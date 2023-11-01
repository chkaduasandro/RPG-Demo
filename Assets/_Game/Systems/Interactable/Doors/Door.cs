using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.AI;

public class Door : MonoBehaviour, IInteractable {
	[SerializeField] private NavMeshObstacle navMeshObstacle;
	public bool IsInteractable { get; set; } = true;
	private bool _isOpen;


	public void Interact() {
		if (!IsInteractable) return;
		
		Toggle();
	}

	private void Toggle() {
		if (_isOpen) Close();
		else Open();
		
	}

	private void Open() {
		_isOpen        = true;
		IsInteractable = false;

		transform.DORotate(Vector3.up * -90, 1f).OnComplete(() => {
			IsInteractable = true;
		});
	}

	private void Close() {
		_isOpen        = false;
		IsInteractable = false;
		
		transform.DORotate(Vector3.up * 0, 1f).OnComplete(() => {
			IsInteractable = true;
		});
	}
}
