using UnityEngine;
using System.Collections;

public class GroundScript : MonoBehaviour
{
    public PlayerController player;

	// Use this for initialization
	void Start ()
    {
	}
	
    void OnTriggerEnter(Collider other)
    {
            player.grounded = true;
            Debug.Log("I'm on the ground");
    }

    void OnTriggerExit(Collider other)
    {
        player.grounded = false;
    }
}
