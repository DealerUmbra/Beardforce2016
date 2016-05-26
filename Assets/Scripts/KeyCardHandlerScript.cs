using UnityEngine;
using System.Collections;

public class KeyCardHandlerScript : MonoBehaviour
{
    public DoorHandlerScript doorHandler;

    public bool[] keys;

    private bool key1 = false;

    // ---------------------- Properties for all the keys -------------------
    // ----------------------------------------------------------------------
    public bool Key1
    {
        get{ return key1; }
        set{ key1 = value; }
    }

    // ---------------------- End of Properties -----------------------------
    // ----------------------------------------------------------------------

    
    void Start()
    {
        keys = new bool[4];
    }

    public void Pickup(int key)
    {
        keys[key] = true;
    }

    void OnGUI()
    {
        for(int key = 0; key < keys.Length; key++)
        {
            if (keys[key] == true)
            {
                GUI.Label(new Rect(10, 10 * key, 100, 20), "Key " + key + " obtained");
                doorHandler.Door(key);
            }
        }
    }
}
