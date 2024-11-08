using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    public int eggQuant { get; private set; }

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("egg!");
        eggCollected();

        return true;
    }

    void eggCollected()
    {
        eggQuant++;
        Debug.Log("Collected! Total Egg Score: " + eggQuant);
    }
}
