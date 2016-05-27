#pragma strict

function Start () {

}

function Update () {

}
function OnGUI () 
{
    // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
    if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2, 160, 50), "Play")) 
    {
        Application.LoadLevel ("All_Levels");
    }
}