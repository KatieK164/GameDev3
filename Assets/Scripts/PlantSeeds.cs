using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSeeds : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public GameObject[] tomatoPlants;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Plant!");
        planted();

        return true;
    }

    void planted()
    {
        for (int i = 0; i < tomatoPlants.Length; ++i)
        {
            if (tomatoPlants[i] != null)
            {
                tomatoPlants[i].SetActive(true);
            }
        }
        /*tomatoPlants.setActive(true);*/
        Debug.Log("Planted!");
    }
}
