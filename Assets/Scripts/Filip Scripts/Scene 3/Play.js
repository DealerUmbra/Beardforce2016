#pragma strict

function OnGUI () 
{
    if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2, 160, 50), "Level 1")) 
    {
        Application.LoadLevel ("nh");
    }

    // Make the second button.
     if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2 + 50, 160, 50), "Level 2")) 
     {
        Application.LoadLevel ("nh2");
    }
    
     if(GUI.Button (Rect (Screen.width/2 - 100, Screen.height/2 + 100, 160, 50), "Back")) 
    {
        Application.LoadLevel ("MainMenu");
    }

}
