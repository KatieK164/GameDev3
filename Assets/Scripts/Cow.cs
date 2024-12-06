using I2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    [SerializeField]public int milkQuant = 0;

    public string InteractionPrompt => _prompt;

    [SerializeField] private Item item;
    private Inventory inventory;
    public bool canHarvest = true;
    public LightingManager light;
    public AudioSource moo;
   

    private void Start()
    {
        inventory = FindAnyObjectByType<Inventory>();

    }

    void Update()
    {
        if ((int)light.TimeOfDay != 6)
        {
            return;
        }
        Grown();
    }

    public bool Interact(Interactor interactor)
    {
        if (inventory != null && item != null)
        {
            inventory.AddItem(item);
            Debug.Log("Milk!");
            milkCollected();
            moo.Play();
            //StartCoroutine(milkCycle());
            //Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("it aint werkin");
        }

        return true;
    }

    void milkCollected()
    {
        milkQuant++;
        Debug.Log("Collected! Total Milk Score: " + milkQuant);
        canHarvest = false;
    }


    void Grown()
    {
        if (canHarvest == false)
        {
            
            canHarvest = true;
        }
    }
}
