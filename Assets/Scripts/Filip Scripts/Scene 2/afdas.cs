using UnityEngine;
using System.Collections;

public class afdas : MonoBehaviour 
{ 



	public int curHealth = 100;
	void OnTriggerEnter(Collider other) 
	{
		curHealth -= 51;
	}
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (curHealth < 0) 
		{

		}
	}
}
