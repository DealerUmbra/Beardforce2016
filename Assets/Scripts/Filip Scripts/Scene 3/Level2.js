#pragma strict

function Start () {

}

function OnGUI () 
{
    // Make the second button.
    if (GUI.Button (Rect (0,-54,160,30), "Back")) {
        Application.LoadLevel ("MainMenu");
    }
}