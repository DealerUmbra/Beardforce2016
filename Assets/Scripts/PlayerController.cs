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

    GameObject player;

    private Vector3 movement;

    // Movie Texures
    public MovieTexture walkRight;
    public MovieTexture walkLeft;

    public Rigidbody rb;
    public Renderer rend;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
        walkRight = (MovieTexture)rend.material.mainTexture;
        walkLeft = (MovieTexture)rend.material.mainTexture;
        player = GetComponent<GameObject>();

        rend.material.mainTexture = walkLeft;
    }

    void Update()
    {
        // Code for the animations
        // When the horizontal or vertical keys are pressed and held, the animation starts and loops

        if (Input.GetButtonDown("Right"))
        {
            if(rend.material.mainTexture = walkLeft)
            {
                rend.material.mainTexture = walkRight;
                Debug.Log("He's walking right now");
            }
                
            walkRight.Play();
            walkRight.loop = true;
        }

        if(Input.GetButtonDown("Left"))
        {
            if (rend.material.mainTexture == walkRight)
            {
                rend.material.mainTexture = walkLeft;
                Debug.Log("He's walking left now");
            }

            walkLeft.Play();
            walkLeft.loop = true;
        }

        if(Input.GetButton("Vertical"))
        {
            walkRight.Play();
            walkRight.loop = true;
        }

        // When the horizontal or vertical keys are released, the animation stops
        if (Input.GetButtonUp("Horizontal"))
        {
            walkRight.Pause();
        }

        if (Input.GetButtonUp("Vertical"))
        {
            walkRight.Pause();
        }

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
