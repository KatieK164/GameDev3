using I2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    public int eggQuant = 0;

    public string InteractionPrompt => _prompt;


    [SerializeField] private Item item;
    private Inventory inventory;
    public bool canHarvest = true;


    private void Start()
    {
        inventory = FindAnyObjectByType<Inventory>();

    }

    public bool Interact(Interactor interactor)
    {

        if (inventory != null && item != null)
        {
            inventory.AddItem(item);
            Debug.Log("egg!");
            eggCollected();
            StartCoroutine(eggCycle());
            //Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("it aint werkin");
        }
       

        return true;
    }

    void eggCollected()
    {
        eggQuant++;
        Debug.Log("Collected! Total Egg Score: " + eggQuant);
        canHarvest = false;
    }

    private IEnumerator eggCycle()
    {
        yield return new WaitForSeconds(3);

        canHarvest = true;
    }
}
