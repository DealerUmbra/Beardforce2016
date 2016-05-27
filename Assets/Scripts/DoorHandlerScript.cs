using UnityEngine;
using System.Collections;

public class DoorHandlerScript : MonoBehaviour
{
    //Variables
    public GameObject door1;
    public GameObject door2;
    public GameObject triggerArea;

    public KeyCardHandlerScript keyCardHandler;

    public int doorID;
    public bool enter;
    int keyID;
    public int [] keyList;

    //When someone enters the TriggerArea
    public void OnTriggerEnter(Collider Other)
    {
        int key = 0;
        if(keyCardHandler.keys[key] == true)
        {
            //DÖrern öppnas
            Debug.Log("The door opened successfully");
        }
    }
}
