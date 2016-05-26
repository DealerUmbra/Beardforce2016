using UnityEngine;
using System.Collections;

public class KeycardScript : MonoBehaviour
{
    public KeyCardHandlerScript keyCardHandler;
    public int keyID;

	void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision detected!");
        keyCardHandler.Pickup(keyID);

        Destroy(gameObject);
	}
}
