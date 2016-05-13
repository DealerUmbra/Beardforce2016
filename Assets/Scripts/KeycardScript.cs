using UnityEngine;
using System.Collections;

public class KeycardScript : MonoBehaviour
{
    KeyCardHandlerScript keyCardHandler;

	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected!");
        //keyCardHandler.Key1 = true;

        Destroy(gameObject);
	}
}
