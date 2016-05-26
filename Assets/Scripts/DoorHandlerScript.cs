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
    void OnTriggerEnter(Collider Other)
    {
        enter = true;
    }

    void OnTriggerExit(Collider Other)
    {
        enter = false;
    }

    public void Door(int key)
    {
        if (enter == true)
        {
            if (doorID == keyList[key])
            {
                //The doors opens
                Debug.Log("The door opened successfully");
            }
        }
    }
}
