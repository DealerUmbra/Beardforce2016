#pragma strict
var timer : float = 5.0;

function Update()
{
	timer -= Time.deltaTime;
	
	if(timer <= 0)
	{
		timer = 5;
	}
	if(timer >= 5)
	{
		transform.position.z -= 10;
	}
	
}