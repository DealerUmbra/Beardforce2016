using UnityEngine;
using System.Collections;

public class CamereFollow : MonoBehaviour {
    private Transform target;
    public float CameraY;


	// Use this for initialization
	void Start () {
        
        target = GameObject.FindGameObjectWithTag("PlayerDude").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(target.position.x, target.position.y + CameraY, gameObject.transform.position.z);
    }
}
