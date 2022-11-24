using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D carRigidBody;
    public Rigidbody2D frontTire;
    public Rigidbody2D backTire;

    public float speed = 20;
    public float carTorque = 10;
    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        frontTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        backTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
        carRigidBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
    }
}
