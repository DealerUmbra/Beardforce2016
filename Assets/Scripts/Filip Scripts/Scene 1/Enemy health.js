#pragma strict
var Health : int = 100;
var Player : Transform;
var MoveSpeed = 4;
var MaxDist = 5;
var MinDist = 2;
var startTime;
var timer1 = 5;
 
function Start () 
{
 
}
 
function Update () 
{
    transform.LookAt(Player);
    
    if(Vector3.Distance(transform.position,Player.position) <= MaxDist)
    {
         transform.position += transform.forward*MoveSpeed*Time.deltaTime;
    }
    if(Vector3.Distance(transform.position,Player.position) == MinDist)
    {
    	TimerStart();
    }
    
}
function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.name == "Cube")
    {
        Health -= 5;
    }
    if(Health == 0)
    {
        Destroy(gameObject);   
    }
}
 
 
 
 function TimerStart()
 {
 
 startTime = Time.time; //time starter
 
 timer1 = Time.time;  //Set time
 
 if(timer1 == 0)
 { //<-------the number here are the seconds you want
 transform.Translate(0.7, 0, 0, Camera.main.transform);
 
 }
 if(timer1 == 5)
 { //<-------the number here are the seconds you want
 transform.Translate(-0.7, 0, 0, Camera.main.transform);
 
 }
 }