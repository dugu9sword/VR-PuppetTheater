using UnityEngine;
using System.Collections;

public class MoviePlay : MonoBehaviour {

	//public MovieTexture movieTexture;

	// Use this for initialization
	void Start () {
	//	movieTexture.loop = true;
	//	this.GetComponent<MeshRenderer> ().material.mainTexture = movieTexture;
	//	movieTexture.Play ();
		this.GetComponent<AudioSource> ().Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
