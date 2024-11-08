using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    public int milkQuant { get; private set; }

    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Milk!");
        milkCollected();

        return true;
    }

    void milkCollected()
    {
        milkQuant++;
        Debug.Log("Collected! Total Milk Score: " + milkQuant);
    }
}
