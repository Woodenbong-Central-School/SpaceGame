using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // A dictionary to hold the items and their quantities
    private Dictionary<string, int> items;

    // Initialize the inventory
    void Start()
    {
        items = new Dictionary<string, int>();
    }

    // Add an item to the inventory
    public void AddItem(string itemName, int quantity = 1)
    {
        if (items.ContainsKey(itemName))
        {
            items[itemName] += quantity;
        }
        else
        {
            items[itemName] = quantity;
        }
        Debug.Log("Added " + quantity + " of " + itemName + " to inventory.");
    }

    // Remove an item from the inventory
    public bool RemoveItem(string itemName, int quantity = 1)
    {
        if (items.ContainsKey(itemName))
        {
            if (items[itemName] >= quantity)
            {
                items[itemName] -= quantity;
                if (items[itemName] == 0)
                {
                    items.Remove(itemName);
                }
                Debug.Log("Removed " + quantity + " of " + itemName + " from inventory.");
                return true;
            }
            else
            {
                Debug.LogWarning("Not enough " + itemName + " in inventory.");
                return false;
            }
        }
        else
        {
            Debug.LogWarning(itemName + " not found in inventory.");
            return false;
        }
    }

    // Check if an item is in the inventory
    public bool HasItem(string itemName, int quantity = 1)
    {
        return items.ContainsKey(itemName) && items[itemName] >= quantity;
    }

    // Get the quantity of a specific item
    public int GetItemQuantity(string itemName)
    {
        if (items.ContainsKey(itemName))
        {
            return items[itemName];
        }
        else
        {
            return 0;
        }
    }

    // Display the inventory contents in the console (for debugging)
    public void DisplayInventory()
    {
        Debug.Log("Inventory Contents:");
        foreach (KeyValuePair<string, int> item in items)
        {
            Debug.Log(item.Key + ": " + item.Value);
        }
    }
}