using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();
    void Start()
    {
        items.Add(new Item("grapes", 0, "tastes good", 0, 0, Item.ItemType.Consumable));
        items.Add(new Item("Steel Sword", 0, "Starter Wep", 2, 1, Item.ItemType.Weapon));
    }
}
