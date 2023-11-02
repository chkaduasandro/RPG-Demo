using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IContainer {
	
	public int Capacity { get; set; }
	public List<Item> Items {get; set;}

	public bool TryAddItem(Item item);
	public bool TryTakeItem(Item itemToTake, out Item item);
}
