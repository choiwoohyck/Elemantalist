using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour {
	public Transform targetTr;


	// Use this for initialization
	void Start () {

	}
	void LateUpdate () {


		transform.position = Vector3.Lerp(transform.position,targetTr.position,2f * Time.deltaTime); 
		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x,-11f,11f),
			Mathf.Clamp(transform.position.y,-12.5f,12f),
			transform.position.z
		);
		transform.Translate (0, 0, -10);	
		/*tr.position = Vector3.Lerp (tr.position, targetTr.position - (targetTr.forward * dist) + (Vector3.up * heihgt), Time.deltaTime * dampTrace);
			tr.LookAt (targetTr.position);*/

	}


}
