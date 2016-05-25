#pragma strict

function Start () 
{

}
function OnGUI () 
{
    // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
    if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2, 160, 50), "Play")) 
    {
        Application.LoadLevel ("nh");
    }

    // Make the second button.
     if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2 + 50, 160, 50), "Level Select")) 
     {
        Application.LoadLevel ("LevelSelect");
    }
    
     if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2 + 100, 160, 50), "Credits")) 
    {
        Application.LoadLevel ("Credits");
    }

    // Make the second button.
    if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2 + 150, 160, 50), "Exit")) 
    {
        Application.Quit ();
    }
}