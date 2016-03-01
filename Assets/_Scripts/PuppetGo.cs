using UnityEngine;
using System.Collections;

public class PuppetGo : MonoBehaviour {

	GameObject rotateCenter;
	float speed;
	float self;

	// Use this for initialization
	void Start () {
		rotateCenter = GameObject.FindGameObjectWithTag ("Player");
		speed = Random.Range (20.0f, 50.0f);
		self = Random.Range (100.0f, 300.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (rotateCenter) {
			transform.RotateAround (
				rotateCenter.transform.position,
				rotateCenter.transform.up, 
				Time.deltaTime * speed
			);
			transform.Rotate(transform.up,Time.deltaTime*self);
			//transform.LookAt(rotateCenter.transform);
		}
	}
}
