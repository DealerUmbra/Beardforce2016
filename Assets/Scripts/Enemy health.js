#pragma strict
var Health = 100;
 
 function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.name == "Cube")
    {
    		Health -= 100;
    }
}