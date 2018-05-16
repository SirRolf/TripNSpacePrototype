using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {

	public float moveSpeed;

	void Update () {
			transform.Translate(0, -moveSpeed, 0);
	}
}
