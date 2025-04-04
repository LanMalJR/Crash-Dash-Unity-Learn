using UnityEngine;

public class WheelSteering : MonoBehaviour
{
    public float maxSteerAngle = 30f;
    public string inputAxis = "Horizontal";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis(inputAxis);
        float steerAngle = maxSteerAngle * horizontalInput;
        transform.localRotation = Quaternion.Euler(0, steerAngle, 0);
    }
}
