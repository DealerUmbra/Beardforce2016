#pragma strict
 var Health : int = 100;
 var texture1 : Texture2D;
function Start () {

}

function Update () 
{
     if(Health < 0)
     {
         GetComponent.<Renderer>().material.mainTexture = texture1;
     }
}
function OnTriggerEnter (other : Collider)
 {
     Health -= 51;
 }