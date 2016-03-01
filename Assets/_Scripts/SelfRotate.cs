using UnityEngine;
using System.Collections;

public class SelfRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (Vector3.up,0.8f*Time.deltaTime);
	}
}
