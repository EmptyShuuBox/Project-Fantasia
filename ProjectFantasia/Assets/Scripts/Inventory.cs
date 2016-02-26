using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Inventory : MonoBehaviour {
    public int slotsx, slotsy;
    public List<Item> inventory = new List<Item>();
    public List<Item> slots = new List<Item>();
    private ItemDatabase database;
    public bool showInventory;

    void Start()
    {
        for (int i = 0; i< (slotsx* slotsy); i++)
        {
            slots.Add(new Item());
            inventory.Add(new Item());
        }
        database = GameObject.Find("ItemDatabase").GetComponent<ItemDatabase>();
        inventory[0] = (database.items[0]);
        inventory[1] = database.items[1];
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            showInventory = !showInventory;
        }
    }
    void OnGUI()
    {
        if(showInventory)
        {
            DrawInventory();
        }
        
    }
    void DrawInventory()
    {
        int i = 0;
        for (int x = 0; x<slotsx ;x++)
        {
            for (int y = 0; y< slotsy; y++)
            {
                Rect slotRect = new Rect(x * 60, y * 60, 50, 50);
                GUI.Box(slotRect, "");
                slots[i] = inventory[i];
                if(slots[i].itemName != null)
                {
                    GUI.DrawTexture(slotRect,slots[i].itemIcon);
                }
                i++;
            }
        }
    }
}
