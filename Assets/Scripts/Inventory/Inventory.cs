using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace I2
{
    public class Inventory : MonoBehaviour
    {
        public TMP_Text moneyText;
        List<Item> inventoryList;
        //private TomatoPlant tomatoPlant;
        public int money = 0;

        void Start()
        {
            inventoryList = new List<Item>();
        }
        void Update()
        {
            moneyText.SetText("Money: " + money);
        }

        //delegate event where inv updates
        public delegate void InvDelegate();
        public static event InvDelegate OnInventoryChange;


        public void AddItem(Item item)
        {
            if (inventoryList.Count == 0)
            {
                inventoryList.Add(item);
            }
            else
            {
                bool inList = false;

                foreach (Item i in inventoryList)
                {
                    if (item.itemName == i.itemName)
                    {
                        i.stackSize++;

                        inList = true;
                    }
                }
                if (!inList)
                {
                    inventoryList.Add(item);
                }
            }
            OnInventoryChange?.Invoke();
        }



        public List<Item> GetInventoryList()
        {
            return inventoryList;
        }


        void OnTriggerEnter(Collider gameObject)
        {
            if (gameObject.tag == "Sell")
            {
                Debug.Log("Selling");

                foreach (Item i in inventoryList)
                {
                    if (i.itemName == "Tomato")
                    {
                        money += (i.stackSize * 10);
                        i.stackSize = 0;
                    }
                    else if (i.itemName == "milk")
                    {
                        money += (i.stackSize * 20);
                        i.stackSize = 0;
                    }
                    else if (i.itemName == "Eggs")
                    {
                        money += (i.stackSize * 15);
                        i.stackSize = 0;
                    }
                    else
                    {
                        Debug.Log("Nothing to sell!");

                    }
                }
                OnInventoryChange?.Invoke();
            }

        }

        /*public void RemoveItem(Item item, int quantity)
        {
            var existingItem = inventoryList.Find(i => i.itemName == item.itemName);
            if (existingItem != null)
            {
                existingItem.stackSize -= quantity;
                if (existingItem.stackSize <= 0)
                {
                    inventoryList.Remove(existingItem);
                }

                OnInventoryChange?.Invoke();
            }

        }*/



    }
}


