using I2;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Selling : MonoBehaviour
{
    public TMP_Text moneyText;
    public Inventory inventory;
    
    int money = 0;
    // Start is called before the first frame update
    void Start()
    {
        //List<Item> invList = inventory.inventoryList;
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.SetText("Money: " + money);
    }

    void OnTriggerEnter(Collider gameObject)
    {
        if (gameObject.tag == "Sell")
        {
            Debug.Log("Selling");

            //foreach (Item i in inventory.inventoryList)
            //{
            //    //Item i = invList[i];
            //    if (i.itemName == "Tomato")
            //    {
            //        money += (i.stackSize * 10);
            //        i.stackSize = 0;
            //    }
            //    else if (i.itemName == "milk")
            //    {
            //        money += (i.stackSize * 20);
            //        i.stackSize = 0;
            //    }
            //    else if (i.itemName == "Eggs")
            //    {
            //        money += (i.stackSize * 15);
            //        i.stackSize = 0;
            //    }
            //    else
            //    {
            //        Debug.Log("Nothing to sell!");

            //    }
            //}
        }
    }
}
