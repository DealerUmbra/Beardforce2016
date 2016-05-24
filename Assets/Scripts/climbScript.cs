using UnityEngine;
using System.Collections;

public class climbScript : MonoBehaviour
{
    public PlayerController player;

    void Start()
    {
    }

    void OnTriggerEnter (Collider other)
    {
        player.ladder = true;
        Debug.Log("The Player can now climb the ladder");
    }

    void OnTriggerExit (Collider other)
    {
        player.ladder = false;
    }
}
