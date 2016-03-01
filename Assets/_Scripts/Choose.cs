using UnityEngine;
using System.Collections;

public class Choose : MonoBehaviour {

	private GameObject vrvideo,vrgame;
	private Vector3 normal,scale;

	// Use this for initialization
	void Start () {
		vrvideo = GameObject.Find ("vrvideo");
		vrgame = GameObject.Find ("vrgame");
		normal = new Vector3 (0.05f, 0.63f, 1.21f);
		scale = normal*1.1f;
	}
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit hit;
		if(Physics.Raycast(transform.position,transform.up,out hit)){
			if (hit.collider.gameObject.name == "vrvideo") {
				vrvideo.transform.localScale = scale;
				vrgame.transform.localScale = normal;
			} else if (hit.collider.gameObject.name == "vrgame") {
				vrvideo.transform.localScale = normal;
				vrgame.transform.localScale = scale;
			}else {
					vrvideo.transform.localScale = normal;
					vrgame.transform.localScale = normal;
			}

			if (Input.GetMouseButtonDown(0)) {
				if (hit.collider.gameObject.name == "vrvideo") {
					Application.LoadLevel ("Video");
				} else if (hit.collider.gameObject.name == "vrgame") {
					Application.LoadLevel ("Game");
				}
			}
		}
	}
}
