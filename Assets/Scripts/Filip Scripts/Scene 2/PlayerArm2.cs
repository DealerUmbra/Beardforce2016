using UnityEngine;
using System.Collections;

public class PlayerArm2 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		transform.localPosition += transform.forward * Time.deltaTime;
	}
	void OnTriggerEnter(Collider other)
	{
		transform.position = new Vector3(transform.position.x, transform.position.y, 26);
	}
}
