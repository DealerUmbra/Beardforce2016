using UnityEngine;
using System.Collections;

public class CamereFollow : MonoBehaviour {
    public Transform target;
    public float CameraY;
    public float CameraZ;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = new Vector3(target.position.x, target.position.y + CameraY, CameraZ);
    }
}
