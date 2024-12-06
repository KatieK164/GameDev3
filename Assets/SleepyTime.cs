using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using I2;
using static UnityEditor.Progress;
using TMPro;


public class SleepyTime : MonoBehaviour, Iinteractable
{
    public TMP_Text dayText;
    public int day = 1;
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;
    public LightingManager light;
    public AudioSource audioSource;
    // Start is called before the first frame update


    public bool Interact(Interactor interactor)
    {
        day++;
        light.TimeOfDay = 6f;
        dayText.SetText("Day: "+day);
        audioSource.Play();

        return true;
    }
}
