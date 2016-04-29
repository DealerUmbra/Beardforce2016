#pragma strict
var Health : int = 100;
var Player : Transform;
var MoveSpeed = 4;
var MaxDist = 10;
var MinDist = 5;
 
function Start () 
{
 
}
 
function Update () 
{
    transform.LookAt(Player);
    
    if(Vector3.Distance(transform.position,Player.position) >= MinDist)
    {
         transform.position += transform.forward*MoveSpeed*Time.deltaTime;
    }
    
}
function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.name == "Player")
    {
        Health -= 50;
    }
    if(Health == 0)
    {
        Destroy(gameObject);   
    }
}