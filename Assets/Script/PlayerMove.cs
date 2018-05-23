using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float rotationSpeed;
	public float moveSpeed;

	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontal, vertical, 0);

		if (direction.magnitude > 1)
			direction.Normalize();

		transform.Translate(direction * moveSpeed * Time.deltaTime);
		/*
		if(Vertical == 1)
		{
			transform.Translate(0, moveSpeed, 0);
		}
		else if(Vertical == -1)
		{
			transform.Translate(0, -moveSpeed, 0);
		}

		if(Horizontal == -1)
		{
			transform.Translate(-moveSpeed, 0, 0);
		}
		if(Horizontal == 1)
		{
			transform.Translate(moveSpeed, 0, 0);
			//transform.Rotate(rotationSpeed * Vector3.back * Time.deltaTime);
		}
		*/
	}
}
