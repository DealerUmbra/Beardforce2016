using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{

    // Variables
    public float moveSpeed;
    public float jumpSpeed;
    public float gravity;

    private float moveX;
    private float moveY;

    private Vector2 move;
    //private Vector2 gravityDown;

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        // Old code using the RigidBody for movement
        // GetComponent<Rigidbody>().velocity = new Vector2(moveX * moveSpeed, moveY * moveSpeed);

        // Movement code using transform
        move = new Vector3(moveX, moveY, 0);
        transform.position = move * moveSpeed * Time.deltaTime;


        //Code for gravity
        /*gravityDown = new Vector2(0, gravity);
        transform.position = gravityDown * gravity * Time.deltaTime;*/
    }
}
