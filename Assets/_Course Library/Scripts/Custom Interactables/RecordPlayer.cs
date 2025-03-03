using System;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR.Interaction.Toolkit;

public class RecordPlayer : MonoBehaviour
{

    // var socketGO = socket game object
    public GameObject socket;
    // var redRecordGO = record red game object
    public GameObject redRecord;
    // var blueRecordGO = record blue game object
    public GameObject blueRecord;

    // var currentRecord = record currently attached to socketGO
    private GameObject currentRecord;
    // var socketAS = socket audio source
    public AudioSource audioSource;
    // var redRecordAF = record red audio file
    public AudioSource redAudio;
    // var blueRecordAF = record blue audio file
    public AudioSource blueAudio;

    void Start()
    {

    }

    void Update()
    {

    }

    // decides and plays audio
    public void PlayRecord(SelectEnterEventArgs args)
    {
        currentRecord = //gameobject currently attached to the socket;
        // if (currentRecord = redRecordGO){
        if (currentRecord == redRecord)
        {
            // socketAS = redRecordAF
            audioSource = redAudio;
        }
        // } else if (currentRecord = blueRecordGO){
        else if (currentRecord == blueRecord)
        {
            // socketAS = blueRecordAF
            audioSource = blueAudio;
        }
        // } else {
        else
        {
            // socketAS = null
            audioSource = null;
        }
        // }
        // play_audio(socketAS)
        audioSource.Play();

    }

    // stops audio
    public void StopRecord(SelectExitEventArgs args)
    {
        // stop_audio(socketAS)
        audioSource.Stop();
        // socketAS = null
        audioSource = null;
    }

}