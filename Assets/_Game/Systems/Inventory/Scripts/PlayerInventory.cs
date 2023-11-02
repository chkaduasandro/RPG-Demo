public class PlayerInventory : Inventory {
	public static PlayerInventory Instance;
	public void Awake() {
		if (Instance == null) {
			Instance = this;
		}
		else {
			Destroy(gameObject);
		}
	}

	public override bool TryAddItem(Item item) {
		return base.TryAddItem(item);
	}

	public override bool TryTakeItem(Item itemToTake, out Item item) {
		return base.TryTakeItem(itemToTake, out item);
	}
}