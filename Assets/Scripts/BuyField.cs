using I2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyField : MonoBehaviour, Iinteractable
{
    private Inventory inventory;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public GameObject gate;



    public bool Interact(Interactor interactor)
    {
        Debug.Log("Field");
        if (inventory.money > 50)
        {
            Debug.Log("Buying Field");
            BuyingField();

        }
        return true;
    }

    void BuyingField()
    {
        inventory.money -= 50;
        gate.SetActive(false);
    }




}
