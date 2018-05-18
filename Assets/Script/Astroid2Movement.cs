using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid2Movement : MonoBehaviour {

	public float moveSpeedMin = 0.1f;
	public float moveSpeedMax = 0.2f;

	private float moveSpeed;

	void Start()
	{
		moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
	}

	void Update () {
			transform.Translate(0, -moveSpeed, 0);
	}
}
