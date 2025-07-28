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


    }

    private void AddVelocity()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = x * transform.right + z * transform.forward;

        movement = movement * speed * Time.deltaTime;


        myController.Move(movement);
    }
}
