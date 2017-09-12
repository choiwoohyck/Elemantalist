using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element_effect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Black") {
			Debug.Log ("Black");
			Destroy (coll.gameObject);
		} else if (coll.gameObject.tag == "Blue") {
			Debug.Log ("Blue");
			Destroy (coll.gameObject);
		} else if (coll.gameObject.tag == "Orange") {
			Debug.Log ("Orange");
			Destroy (coll.gameObject);
		} else if (coll.gameObject.tag == "Purple") {
			Debug.Log ("Purple");
			Destroy (coll.gameObject);
		} else if (coll.gameObject.tag == "Red") {
			Debug.Log ("Red");
			Destroy (coll.gameObject);
		} else if (coll.gameObject.tag == "Yellow") {
			Debug.Log ("Yellow");
			Destroy (coll.gameObject);
		} else if (coll.gameObject.tag == "Green") {
			Debug.Log ("Green");
			Destroy (coll.gameObject);
		}

	}
}
