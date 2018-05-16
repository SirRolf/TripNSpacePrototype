using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float rotationSpeed;
	public float moveSpeed;

	void Update () {
		float Horizontal = Input.GetAxisRaw("Horizontal");
		float Vertical = Input.GetAxisRaw("Vertical");

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
			//transform.Rotate(rotationSpeed * Vector3.forward * Time.deltaTime);
		}
		if(Horizontal == 1)
		{
			transform.Translate(moveSpeed, 0, 0);
			//transform.Rotate(rotationSpeed * Vector3.back * Time.deltaTime);
		}

	}
}
