using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform MyPlayerHead;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       LockCamera();
    }


    private void LateUpdate()
    {
    
        UpdateCameraMovement();
      
    }

    void LockCamera()
    {
        Cursor.lockState = CursorLockMode.Locked;//hide our cursor
    }

    void UpdateCameraMovement()
    {
        transform.position = MyPlayerHead.position;
        transform.rotation = MyPlayerHead.rotation;
    }
}
