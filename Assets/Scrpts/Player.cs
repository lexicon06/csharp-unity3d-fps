using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 12.3f;
    public CharacterController myController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        myController.Move(Vector3.forward * speed);
    }
}
