using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int tomatoQuant { get; private set; }
    public int cabbageQuant = 0;

public UnityEvent<PlayerInventory> OnTomatoCollected;

    public void TomatoCollected()
    {
        tomatoQuant++;
        Debug.Log("Collected! Total Tomato Score: " + tomatoQuant);
        
        OnTomatoCollected.Invoke(this);
    }

    /*public UnityEvent<PlayerInventory> OnCabbageCollected;

    public void CabbageCollected()
    {
        cabbageQuant++;
        OnCabbageCollected.Invoke(this);
    }*/



    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Hey");

    //    if (collision.collider.tag == "Tomato")
    //    {
    //        GameObject tomato = collision.gameObject;
    //        tomatoquant++;
    //        Debug.Log("Collected! Total Tomato Score: " + tomatoquant);
    //        Destroy(tomato);
    //    }
    //    else if (collision.collider.tag == "Cabbage")
    //    {
    //        GameObject cabbageVeg = collision.gameObject;
    //        cabbage++;
    //        Debug.Log("Collected! Total Cabbage Score: " + cabbage);
    //        Destroy(cabbageVeg);
    //    }
    //}
}

