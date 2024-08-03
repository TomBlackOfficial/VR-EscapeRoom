using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    bool trig, open;
    bool ePressed = false;
    public float smooth = 2.0f;
    public float DoorOpenAngle = 90.0f;
    public float rotationTolerance = 1.0f; // Tolerance for stopping rotation
    private Quaternion defaultRot;
    private Quaternion openRot;

    void Start()
    {
        defaultRot = transform.rotation;
        openRot = Quaternion.Euler(defaultRot.eulerAngles + Vector3.up * DoorOpenAngle);
    }

    void Update()
    {
        if (open && Quaternion.Angle(transform.rotation, openRot) > rotationTolerance)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, openRot, Time.deltaTime * smooth);
        }
        else if (!open && Quaternion.Angle(transform.rotation, defaultRot) > rotationTolerance)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, defaultRot, Time.deltaTime * smooth);
        }
    }

    public void OpenDoor() 
    {
        open = true;
    }
}
