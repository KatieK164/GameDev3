using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collectable : MonoBehaviour
{
    private bool isPlayerInRange = false;
    public int tomatoQuant = 1; 

    private void OnTriggerEnter(Collider other)
    {
        // Check if entering is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true; // Player in range
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // When the player exits the trigger area, set isPlayerInRange to false
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false; // Player is out of range
        }
    }

    private void Update()
    {
        // Check if the player is in range and presses the "E" key
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // Collect the item
            Collect();
        }
    }

    // Function to handle the collection of the item
    void Collect()
    {
        // Assuming the player has a PlayerInventory script attached for score tracking
        GameObject player = GameObject.FindWithTag("Player");
        PlayerInventory playerInventory = player.GetComponent<PlayerInventory>();
        if (playerInventory != null)
        {
            playerInventory.AddToInventory(tomatoQuant);
            Debug.Log("Collected");
        }

        // Play a sound, animation, or visual effect (optional)
        // Destroy the collectable object after it's collected
        Destroy(gameObject);
    }
}