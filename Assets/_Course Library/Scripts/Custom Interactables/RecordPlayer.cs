using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class RecordPlayer : MonoBehaviour
{
    public float rotationSpeed = 33.3f;

    // var socketGO = socket game object
    public GameObject socket;
     // var redRecordGO = record red game object
    public GameObject redRecord;
        // var blueRecordGO = record blue game object
    public GameObject blueRecrod;

    // var currentRecord = record currently attached to socketGO

    // var socketAS = socket audio source
    // var redRecordAF = record red audio file
    // var blueRecordAF = record blue audio file

    void Start()
    {

    }

    void Update()
    {

    }

// decides and plays audio
    public void PlayRecord()
    {
        // if (currentRecord = redRecordGO){
        // socketAS = redRecordAF
        // } else if (currentRecord = blueRecordGO){
        // socketAS = blueRecordAF
        // } else {
        // socketAS = null
        // }
        // play_audio(socketAS)

    }

// stops audio
    public void StopRecord()
    {
        // stop_audio(socketAS)
        // socketAS = null
    }

// spinning record when playing
    public void StartSpinObject()
    {
        // continously rotate on x-axis 
        transform.Rotate(2*rotationSpeed*Time.deltaTime, 0, 0);
    }

    public void StopSpinObject()
    {
        // stop rotating
        transform.Rotate(0,0,0);
    }

}