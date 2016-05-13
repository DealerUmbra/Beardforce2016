using UnityEngine;
using System.Collections;

public class KeyCardHandlerScript : MonoBehaviour
{
    private bool key1 = false;



    public bool Key1
    {
        get
        {
            return key1;
        }
        set
        {
            key1 = value;
        }
    }
}
