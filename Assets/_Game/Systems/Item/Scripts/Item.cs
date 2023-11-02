using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item {
	public ItemData ItemData;
	
	public Item(ItemData itemData) {
		this.ItemData = itemData;
	}
}