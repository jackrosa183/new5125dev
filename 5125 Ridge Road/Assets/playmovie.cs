using UnityEngine;
using System.Collections;

public class playmovie : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
	}
}
