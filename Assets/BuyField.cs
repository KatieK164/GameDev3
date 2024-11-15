using I2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyField : MonoBehaviour, Iinteractable
{
    private Inventory inventory;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => throw new System.NotImplementedException();

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Field");
        if (inventory.money >= 50)
        {
            Debug.Log("Buying Field");
            inventory.money-=50;
            gameObject.SetActive(false);
        }
        return true;
    }

}
