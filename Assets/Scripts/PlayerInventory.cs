using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int totalScore = 0;

    // Function to add score when a collectable is picked up
    public void AddToInventory(int value)
    {
        totalScore += value;
        Debug.Log("Collected! Total Score: " + totalScore);
    }
}

