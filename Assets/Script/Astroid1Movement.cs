using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid1Movement : MonoBehaviour {

	public float moveSpeedDown;
	public float moveSpeedLeft;
	private float timer = 0;
	private float DeathTime = 4;

	void Awake() {
		moveSpeedLeft = Random.Range(0.1f, 0.2f);
	}

	void Update () {
			transform.Translate(-moveSpeedLeft, -moveSpeedDown, 0);

			timer += Time.deltaTime;
			if (timer >= DeathTime)
			{
				Destroy(gameObject);
			}
	}
}
