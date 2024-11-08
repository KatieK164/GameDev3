using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tomato : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    public int tomatoQuant { get; private set; }

    public string InteractionPrompt => _prompt;
   
   public bool Interact(Interactor interactor)
   {
        Debug.Log("Tomato!");
        tomatoCollected();
        
        return true;
   }

    void tomatoCollected(){
        tomatoQuant++;
        Debug.Log("Collected! Total Tomato Score: " + tomatoQuant);
        DestroyImmediate(gameObject);
    }
}
