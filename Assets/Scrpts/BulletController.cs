using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float Speed;
    public Rigidbody MyRigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }


    void MoveBullet()
    {
        MyRigidBody.linearVelocity = transform.forward * Speed;
    }
}
