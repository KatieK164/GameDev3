using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace I2 {
    public class Inventory : MonoBehaviour
    {
        List<Item> inventoryList;


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

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Tomato")
            {
                AddItem(other.GetComponent<Item>());
            }
            other.gameObject.SetActive(false);
        }
    }

  }

