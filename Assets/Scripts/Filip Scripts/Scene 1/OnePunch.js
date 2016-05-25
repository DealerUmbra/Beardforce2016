#pragma strict
 var Punch = false;
 function Update() 
 {
     if (Input.GetKeyDown(KeyCode.E)) 
     {
         transform.Translate(0.7, 0, 0, Camera.main.transform);
         Punch = true;
     }
     if (Input.GetKeyUp(KeyCode.E)) 
     {
         transform.Translate(-0.7, 0, 0, Camera.main.transform);
         Punch = true;
     }
 }
 
 