using System;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class RecordPlayer : MonoBehaviour
{
    // defining variables
    XRSocketInteractor socket;    

    public GameObject redVinyl;
    public GameObject blueVinyl;
    private GameObject currentVinyl;

    public AudioSource audioSource;
    public AudioSource redAudio;
    public AudioSource blueAudio;

    void Start()
    {
        socket = GetComponent<XRSocketInteractor>(); 
    }

    void Update()
    {

    }
    
    // plays audio
    public void PlayVinyl(SelectEnterEventArgs args)
    {
        IXRSelectInteractable selectedObject = socket.GetOldestInteractableSelected();
        currentVinyl = selectedObject.transform.gameObject;

        if (currentVinyl == redVinyl)
        {
            audioSource = redAudio;
        }
        else if (currentVinyl == blueVinyl)
        {
            audioSource = blueAudio;
        }
        else
        {
            audioSource = null;
        }
        // play audio
        audioSource.Play();

    }

    // stops audio
    public void StopVinyl(SelectExitEventArgs args)
    {
        audioSource.Stop();
        audioSource = null;
    }

}

