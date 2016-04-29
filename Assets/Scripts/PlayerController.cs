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

    // Movie Texures
    public MovieTexture[] animations;
    int aniIndex = 0;

    public Rigidbody rb;
    public Renderer rend;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        // Code for the animations
        // When the horizontal or vertical keys are pressed and held, the animation starts and loops

        rend.material.mainTexture = animations[aniIndex];

        if (Input.GetButtonDown("Right"))
        {
            if(aniIndex != 2)
            {
                aniIndex = 2;
                Debug.Log("He's walking right now");
            }
        }

        if(Input.GetButtonDown("Left"))
        {
            if (aniIndex != 1)
            {
                aniIndex = 1;
                Debug.Log("He's walking left now");
            }
        }

        /*if(Input.GetButton("Vertical"))
        {
            //Put code for vertical events
        }*/

        // When the horizontal or vertical keys are released, the animation stops
        if (Input.GetButtonUp("Horizontal"))
        {
            aniIndex = 0;
        }

        if (Input.GetButtonUp("Vertical"))
        {
            aniIndex = 0;
        }

        animations[aniIndex].Play();
        animations[aniIndex].loop = true;
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
