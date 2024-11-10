using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using I2;


public class TomatoPlant : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] public int tomatoQuant = 0;
    //{ get; public set; }
    public string InteractionPrompt => _prompt;

    [SerializeField] private Item item;
    private Inventory inventory;

    private void Start()
    {
        inventory = FindAnyObjectByType<Inventory>();

    }
    public bool Interact(Interactor interactor)
    {
        if (inventory != null && item != null)
        {
            inventory.AddItem(item);
            Debug.Log("Tomato Plant!");
            tomatoHarvested();
            //Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("it aint werkin");
        }


        return true;
    }

    void tomatoHarvested()
    {
        tomatoQuant += 5;
        Debug.Log("Collected! Total Tomato Score: " + tomatoQuant);
        transform.GetChild(0).gameObject.SetActive(false);

        //tomatoText.SetText("Tomato: \n" + tomatoQuant);
        //Destroy(gameObject);
    }
}
