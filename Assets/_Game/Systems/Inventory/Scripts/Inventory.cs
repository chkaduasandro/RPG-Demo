using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour,IContainer {
    public int Capacity { get; set; }
    public List<Item> Items { get; set; }

    public virtual bool TryPutItem(Item item) {
        return false;
    }

    public virtual bool TryTakeItem(Item itemToTake,out Item item) {

        item = itemToTake;
        return false;
    }
}
