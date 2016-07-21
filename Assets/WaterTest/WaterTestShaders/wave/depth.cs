using UnityEngine;
using System.Collections;

public class depth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.camera.depthTextureMode = DepthTextureMode.Depth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
