using I2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    private TomatoPlant tomatoPlant;
    private Inventory inventory;

    public int money;

    private void Start()
    {
        inventory = FindAnyObjectByType<Inventory>();

    }

        public bool Interact(Interactor interactor)
    {
          if (tomatoPlant.tomatoQuant > 0)
          {
              int tomatoes = tomatoPlant.tomatoQuant;
              money += (tomatoes * 10);
              tomatoes = 0;
              Debug.Log("Money: " + money);

          }

        
        return true;
    }




}
