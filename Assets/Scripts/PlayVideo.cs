using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour
{
    public MovieTexture testTex;
	
	// Update is called once per frame
	void Start ()
    {
        GetComponent<Renderer>().material.mainTexture = testTex;
        testTex.Play();
        testTex.loop = true;
	}
}
