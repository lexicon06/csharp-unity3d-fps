using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 12.3f;
    public CharacterController MyController;
    public float MouseSensitivity = 600f;
    public Transform MyCameraHead;
    private float CameraVerticalRotation;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
    
         ✅ Option 1: Re-enable Legacy Input (quickest fix)
If you want to keep using Input.GetAxis, do this:

Go to Edit → Project Settings → Player

Under Other Settings, find Active Input Handling

Set it to Both

Unity will prompt a restart—accept it

This lets you use both input systems side by side, and your current code will work as-is.

        */


        AddVelocity();

        float mouseX = Input.GetAxisRaw("Mouse X") * MouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * MouseSensitivity * Time.deltaTime;

        CameraVerticalRotation -= mouseY;

        transform.Rotate(Vector3.up * mouseX);
        MyCameraHead.localRotation = Quaternion.Euler(CameraVerticalRotation, 0f, 0f);
    }

    private void AddVelocity()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = z * transform.forward + x * transform.right;

        movement = movement * Speed * Time.deltaTime;


        MyController.Move(movement);
    }
}
