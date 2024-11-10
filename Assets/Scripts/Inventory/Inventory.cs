using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace I2 {
    public class Inventory : MonoBehaviour
    {
        List<Item> inventoryList;
        //private TomatoPlant tomatoPlant;


        void Start()
        {
            inventoryList = new List<Item>();
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

