using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public string itemName;
    public Sprite itemIcon;
    public Item item;

       
    void Start()
    {
        item = new Item();

        item.itemName = itemName;
        item.itemIcon = itemIcon;

     }

    public Item GetItem()
    {
        return item;
    }
  }

