#pragma strict

function Start () {

}
function OnGUI () 
{
    // Make the second button.
    if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2 + 100, 160, 50), "Back")) 
    {
        Application.LoadLevel ("MainMenu");
    }
}