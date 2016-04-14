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
	

	// Update is called once per frame
	void FixedUpdate ()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = new Vector2(moveX * moveSpeed, moveY * moveSpeed);



	}
}
