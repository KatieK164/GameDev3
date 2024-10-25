using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collectable : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hey");
        // Check as "Player"
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();

        if (inventory != null)
        {
            //if (other.tag == "Tomato")
            {
                inventory.TomatoCollected();
                Destroy(gameObject);
                Debug.Log("Tomato collected:" + inventory.tomatoQuant);
            }

            //else if (other.tag == "Cabbage")
            //{
            //    inventory.CabbageCollected();
            //    Destroy(gameObject);
            //    Debug.Log("Cabbage collected:" + inventory.cabbageQuant);
            //}


        }

    }
}