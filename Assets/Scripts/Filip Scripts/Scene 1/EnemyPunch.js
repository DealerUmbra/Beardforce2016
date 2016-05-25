#pragma strict

var timer : float = 3.0;
var timer2 : float = 3.0;
function Update()
{
	timer -= Time.deltaTime;
	timer2 -= Time.deltaTime;
	
	if(timer <= 0)
	{
		timer = 3;
		transform.position.z += 0.5;
	}
	if(timer2 <= 0)
	{
		timer = 3;
		transform.position.z += 0.5;
	}
	
}