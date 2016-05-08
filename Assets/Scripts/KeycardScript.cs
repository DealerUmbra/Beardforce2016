using UnityEngine;
using System.Collections;

public class KeycardScript : MonoBehaviour
{

	// Update is called once per frame
	void OnCollisionEnter (Collision collision)
    {
        Debug.Log("Collision detected!");

        Destroy(this);
	}
}
