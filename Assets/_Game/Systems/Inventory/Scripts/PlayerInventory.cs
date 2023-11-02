public class PlayerInventory : Inventory {
	public override bool TryPutItem(Item item) {
		return base.TryPutItem(item);
	}

	public override bool TryTakeItem(Item itemToTake, out Item item) {
		return base.TryTakeItem(itemToTake, out item);
	}
}