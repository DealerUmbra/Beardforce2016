using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour
{
    public MovieTexture testTex;
	
	// Update is called once per frame
	void Update ()
    {
        testTex.Play();
        testTex.loop = true;
	}
}
