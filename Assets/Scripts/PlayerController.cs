using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    // Variables
    public float moveSpeed;
    public float jumpSpeed;
    public float gravity;

    private float moveX;
    private float moveY;
    private float moveZ;

    private Vector3 movement;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // Here the Input controller is set for the horizontal and vertical movement
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        // Here the all the inputs in X and Z angles are put into the movement function
        movement = new Vector3(moveX, 0.0f, moveZ);

        // Here the physics are calculated in rigidbody velocity and movement in X and Z togehter with Speed
        rb.velocity = movement * moveSpeed;

        // Changing the gravity in the game (Doesn't quite work like I want yet)
        //Physics.gravity = new Vector3(0, -100f, 0);
    }
}
