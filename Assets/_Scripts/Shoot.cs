using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject[] scores;
	public GameObject winningpanel;
	public AudioClip collected;
	public AudioClip winning;
	int i=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (i == 5) {
			winningpanel.SetActive(true);
			AudioSource.PlayClipAtPoint (winning, transform.position);
			i++;
		}
		RaycastHit hit;
		if(Physics.Raycast(transform.position,transform.up,out hit)){

			if (Input.GetMouseButtonDown(0)) {
				if (hit.collider.gameObject.transform.parent.gameObject.tag == "puppet") {
					Debug.Log ("puppet");
					AudioSource.PlayClipAtPoint (collected, transform.position);
					GameObject.Destroy (hit.collider.gameObject.transform.parent.gameObject);
					i++;
					GameObject.Destroy (scores [scores.Length - i]);
				} 

				if (hit.collider.gameObject.name == "Return"
					||hit.collider.gameObject.name == "WinningPanel") {
					Application.LoadLevel ("House");
				} 
			}
		}
	}
}
