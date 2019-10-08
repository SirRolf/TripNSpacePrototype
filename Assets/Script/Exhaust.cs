using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exhaust : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		float vertical = 0.25f * Input.GetAxis("Vertical");

		Vector3 direction = new Vector3(0.2f, 0, vertical + 0.5f);

		transform.localScale = direction;

		/*
		if (vertical == 0) {
			//become normal
			transform.localScale = new Vector3(0.2f, 0, 0.5f);
		}
		if (vertical == 1) {
			//become bigger
			transform.localScale = new Vector3(0.2f, 0, 0.6f);
		}
		if (vertical == -1) {
			//become smaller
			transform.localScale = new Vector3(0.2f, 0, 0.4f);
		}*/
	}
}
