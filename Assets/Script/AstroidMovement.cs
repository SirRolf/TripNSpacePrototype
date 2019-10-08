﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {

	public float moveSpeedMin = 0.05f;
	public float moveSpeedMax = 0.1f;

	private float moveSpeed;

	void Start()
	{
		moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
	}

	void Update () {
			transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
	}
}
