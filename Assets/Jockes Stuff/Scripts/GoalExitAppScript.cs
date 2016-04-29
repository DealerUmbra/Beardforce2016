using UnityEngine;
using System.Collections;

public class GoalExitAppScript : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "PlayerDude")
        {
            print(col.gameObject.tag);
            Application.Quit();
        }
    }
}
