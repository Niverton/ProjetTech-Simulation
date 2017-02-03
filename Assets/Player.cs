using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		print ("Script player start");
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 move = new Vector3 (horizontal, 0.0f, 0.0f) * speed;

		transform.Rotate (new Vector3 (0.0f, horizontal, 0.0f) );
		transform.Translate (new Vector3 (0.0f, 0.0f, vertical) );
	}
}
