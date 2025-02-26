using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // put variables here
    float rotationSpeed = 33.3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        // spin record
        // transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }

    public void Spin()
    {
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}