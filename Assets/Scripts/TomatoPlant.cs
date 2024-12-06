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
    public LightingManager light;
    public bool canHarvest;
    public GameObject grown;

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
            //StartCoroutine(plantGrow());
            //Destroy(this.gameObject);
            
        }
        else
        {
            Debug.Log("it aint werkin");
        }


        return true;
    }

    void Update()
    {
        if ((int)light.TimeOfDay != 6)
        {
            return;
        }
        Grown();
    }

    void tomatoHarvested()
    {
        if (canHarvest == true)
        {
            tomatoQuant += 5;
            Debug.Log("Collected! Total Tomato Score: " + tomatoQuant);
            grown.SetActive(false);
            canHarvest = false;
            //tomatoText.SetText("Tomato: \n" + tomatoQuant);
            //Destroy(gameObject);
        }

    }

    //private IEnumerator plantGrow()
    //{
    //    yield return new WaitForSeconds(10);
    //    grown.SetActive(true);
    //    canHarvest = true;
    //}

    void Grown()
    {
        if (canHarvest == false)
        {
            grown.SetActive(true);
            canHarvest = true;
        }
    }
}

