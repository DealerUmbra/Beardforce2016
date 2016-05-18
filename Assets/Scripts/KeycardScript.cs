using UnityEngine;
using System.Collections;

public class KeycardScript : MonoBehaviour
{
    public KeyCardHandlerScript keyCardHandler;
    public int keyID;

	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected!");
        keyCardHandler.Pickup(keyID);

        Destroy(gameObject);
	}
}
