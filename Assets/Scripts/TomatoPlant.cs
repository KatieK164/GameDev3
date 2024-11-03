using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoPlant : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    public int tomatoQuant { get; private set; }
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Tomato Plant!");
        tomatoHarvested();

        return true;
    }

    void tomatoHarvested()
    {
        tomatoQuant += 5;
        Debug.Log("Collected! Total Tomato Score: " + tomatoQuant);
        //DestroyImmediate(gameObject);
    }
}
