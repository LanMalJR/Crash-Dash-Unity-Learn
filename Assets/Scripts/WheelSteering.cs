using UnityEngine;

public class WheelSteering : MonoBehaviour
{
    public float maxSteerAngle = 30f;
    public string inputAxis = "Horizontal";

    float horizontalInput;
    float steerAngle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis(inputAxis);
        steerAngle = maxSteerAngle * horizontalInput;
        transform.localRotation = Quaternion.Euler(0, steerAngle, 0);
    }
}
