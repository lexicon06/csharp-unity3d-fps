using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform MyPlayerHead;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//hide our cursor
    }


    private void LateUpdate()
    {
        transform.position = MyPlayerHead.position;
        transform.rotation = MyPlayerHead.rotation;
    }
}
