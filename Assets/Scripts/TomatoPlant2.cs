using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using I2;

public class TomatoPlant2 : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    public int tomatoQuant { get; private set; }
    public string InteractionPrompt => _prompt;
    //public TMP_Text tomatoText;

    // Reference to the player's Inventory (must be set in Unity Inspector)
    [SerializeField] private Inventory _inventory;
    [SerializeField] private Item _tomatoItemPrefab;  // The tomato prefab to be added to inventory

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Tomato Plant!");

        // Harvest tomatoes
        tomatoHarvested();

        return true;
    }

    void tomatoHarvested()
    {
        tomatoQuant += 5;
        Debug.Log("Collected! Total Tomato Score: " + tomatoQuant);

        // Update the UI text for tomatoes
        //tomatoText.SetText("Tomato: \n" + tomatoQuant);

        // Instantiate the tomato item and add it to the inventory
        if (_tomatoItemPrefab != null && _inventory != null)
        {
            Item newTomato = Instantiate(_tomatoItemPrefab);  // Create a new tomato item
            newTomato.stackSize = 1;  // Set stack size (each tomato is 1 for now)

            // Add to inventory
            _inventory.AddItem(newTomato);
            // Optionally, you could destroy the plant after harvesting
            // Destroy(gameObject);
        } 
    }
}
