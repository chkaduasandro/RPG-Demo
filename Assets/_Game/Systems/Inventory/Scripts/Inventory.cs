using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour,IContainer {
    public int Capacity { get; set; }
    public List<Item> Items { get; set; }
    public virtual bool TryAddItem(Item item) {
        if (Items.Count < Capacity) {
            Items.Add(item);
            return true;
        }
        return false;
    }

    public virtual bool TryTakeItem(Item itemToTake, out Item item) {
        item = null;
        if (Items.Contains(itemToTake)) {
            item = itemToTake;
            return true;
        }
        return false;
    }
}
