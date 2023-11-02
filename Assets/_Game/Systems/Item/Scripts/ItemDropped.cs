using System;
using UnityEngine;

public class ItemDropped : MonoBehaviour, IInteractable {
	public bool IsInteractable { get; set; }
	public Item Item;

	private void Start() {
		IsInteractable = true;
	}


	public void Interact() {
		if (Item == null) {
			Debug.LogError("Item Does Not Exist");
			return;
		}
		if(PlayerInventory.Instance.TryAddItem(Item)) Destroy(gameObject);
	}
}