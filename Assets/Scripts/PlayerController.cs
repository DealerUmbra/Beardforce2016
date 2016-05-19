using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    // Variables
    public float moveSpeed;
    public float jumpSpeed;
    public float gravity;

	[FMODUnity.EventRef]
	public string footsteps = "event:/footsteps";


    // Variables for detecting if the player
    // is on the ground or on a ladder
    public bool ladder;
    public bool grounded;

    // Variables for the different axis,
    // this is later used for directions in movement
    private float moveX;
    private float moveY;
    private float moveZ;

    private Vector3 movement;

    // Movie Texures
    public MovieTexture[] animations;
    int aniIndex = 0;

    private int curDirAnimation;

    public Rigidbody rb;
    public Renderer rend;




    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rend = GetComponent<Renderer>();

        ladder = false;

        rend = transform.GetChild(0).GetComponent<Renderer>();

    }

    void Update()
    {
        // Code for the animations
        // When the horizontal or vertical keys are pressed and held, the animation starts and loops

        rend.material.mainTexture = animations[aniIndex];

        // If the player is by a ladder then the ladder bool is true and different control is employed
        // for the player

        if (ladder == true)
        {
            if(Input.GetButtonDown("Vertical"))
            {
                aniIndex = 4;
                
            }
        }
        else
        {
            // The movietextures are stored in an array and has certain indexes for which one
            // to play at the determined commands

            // Code for when the player is walking left
            if (Input.GetButtonDown("Left"))
            {
                // If he's already walking left then he won't walk left again
                if (aniIndex != 2)
                {
                    aniIndex = 2;
                    curDirAnimation = aniIndex;
                    Debug.Log("He's walking left now");
                }
            }

            // Code for when the player is walking right
            if (Input.GetButtonDown("Right"))
            {
                // If he's already walking right then he won't walk right again
                if (aniIndex != 3)
                {
                    aniIndex = 3;
                    curDirAnimation = aniIndex;
                    Debug.Log("He's walking right now");
                }
            }

            // Here is code for when the player is walking up or down and 
            // keeps the movietexture for if he is facing left or right

            if (Input.GetButtonDown("Vertical"))
            {
                aniIndex = curDirAnimation;
            }

    // -------------------------------------- Code for when the player is releasing buttons ------------------------------
    // -------------------------------------------------------------------------------------------------------------------

            // Here's code for when the player is walking up or down
            if (Input.GetButtonUp("Horizontal"))
            {
                // Right
                if (aniIndex == 2)
                {
                    aniIndex = 0;
                }
                // Left
                else if (aniIndex == 3)
                {
                    aniIndex = 1;
                }
            }

            // Here's code for when the player is walking right or left
            if (Input.GetButtonUp("Vertical"))
            {
                // Right
                if (aniIndex == 2)
                {
                    aniIndex = 0;
                }
                // Left
                else if (aniIndex == 3)
                {
                    aniIndex = 1;
                }
            }
        }
    // --------------------------------- Here the animation is started and looped ------------------------------------------
    // ---------------------------------------------------------------------------------------------------------------------

        // if the player is on the ground
        if (grounded == true)
        {
            aniIndex = 5;
            curDirAnimation = aniIndex;

            // Gravity is constantly increasing
            gravity += 5;
        }
        else if(ladder == true)
        {
            // Controls for the animation of the ladder
            if (Input.GetButtonDown("Vertical"))
            {
                animations[aniIndex].Play();
                animations[aniIndex].loop = true;
            }
            if (Input.GetButtonDown("Horizontal"))
            {
                animations[aniIndex].loop = false;
            }
        }
            // Here the code plays the indexed movie texture for the 
            // player and loops it till he releases the button

            animations[aniIndex].Play();
            animations[aniIndex].loop = true;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (ladder == true)
        {
            // Controls for when the player is on the ladder
            moveX = Input.GetAxis("Horizontal");
            moveY = Input.GetAxis("Vertical");
            moveZ = 0;
        }
        else
        {
            // Here the Input controller is set for the horizontal and vertical movement
            moveX = Input.GetAxis("Horizontal");
            moveY = -gravity;
            moveZ = Input.GetAxis("Vertical");
        }

        // Here the all the inputs in X and Z angles are put into the movement function
        movement = new Vector3(moveX, moveY, moveZ);

		FMODUnity.RuntimeManager.PlayOneShot (footsteps);

        // Here the physics are calculated in rigidbody velocity and movement in X and Z togehter with Speed
        rb.velocity = movement * moveSpeed;
    }
}
