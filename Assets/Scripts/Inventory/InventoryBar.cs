using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace I2
{
    public class InventoryBar : MonoBehaviour
    {
        GameObject[] itemSlot;
        List<Item> inventoryList;
        Inventory inventoryScript;

        void Start()
        {
            itemSlot = new GameObject[3];
            inventoryList = new List<Item>();

            itemSlot[0] = transform.GetChild(0).gameObject;
            itemSlot[1] = transform.GetChild(1).gameObject;
            itemSlot[2] = transform.GetChild(2).gameObject;

            inventoryScript = FindObjectOfType<Inventory>().GetComponent<Inventory>();
        }

        private void OnEnable()
        {
            Inventory.OnInventoryChange += UpdateInvBar;
        }

        private void OnDisable()
        {
            Inventory.OnInventoryChange -= UpdateInvBar;
        }



        void UpdateInvBar()
        {
            inventoryList = inventoryScript.GetInventoryList();

            for (int i = 0; i < inventoryList.Count; i++)
            {
                itemSlot[i].gameObject.SetActive(true);
                itemSlot[i].transform.GetChild(2).gameObject.SetActive(true);
                itemSlot[i].transform.GetChild(2).gameObject.GetComponent<Image>().sprite =
                    inventoryList[i].itemIcon;

                itemSlot[i].transform.GetChild(3).transform.GetChild(0).GetComponent<TextMeshProUGUI>().text=
                    inventoryList[i].stackSize.ToString();
            }
        }
    }
}
