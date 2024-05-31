using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    public Inventory inventory;

    void Start()
    {
        inventory = GetComponent<Inventory>();

        // Add some items to the inventory
        inventory.AddItem("Wood", 10);
        inventory.AddItem("Stone", 5);

        // Display the inventory
        inventory.DisplayInventory();

        // Attempt to craft an item
        if (CraftItem("Stone Axe"))
        {
            Debug.Log("Crafted a Stone Axe.");
        }
        else
        {
            Debug.Log("Failed to craft a Stone Axe.");
        }
    }

    bool CraftItem(string itemName)
    {
        // Define the recipe for a Stone Axe
        if (itemName == "Stone Axe")
        {
            if (inventory.HasItem("Wood", 3) && inventory.HasItem("Stone", 2))
            {
                inventory.RemoveItem("Wood", 3);
                inventory.RemoveItem("Stone", 2);
                inventory.AddItem("Stone Axe", 1);
                return true;
            }
            else
            {
                Debug.LogWarning("Not enough materials to craft a Stone Axe.");
                return false;
            }
        }
        return false;
    }
}