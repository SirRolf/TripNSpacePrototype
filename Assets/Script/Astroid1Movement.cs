using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid1Movement : MonoBehaviour {

	public float moveSpeedDownMin = 0.2f;
	public float moveSpeedDownMax = 0.3f;
	public float moveSpeedLeft;

	private float moveSpeedDown;

	void Awake() {
		moveSpeedLeft = Random.Range(6f, 12f);
		moveSpeedDown = Random.Range(moveSpeedDownMin, moveSpeedDownMax);
	}

	void Update () {
		transform.Translate(-moveSpeedLeft * Time.deltaTime, -moveSpeedDown * Time.deltaTime, 0);
	}
}
