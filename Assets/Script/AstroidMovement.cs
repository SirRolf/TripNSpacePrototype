using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidMovement : MonoBehaviour {

	public float moveSpeed;
	private float timer = 0;
	private float DeathTime = 4;

	void Update () {
			transform.Translate(0, -moveSpeed, 0);

			timer += Time.deltaTime;
			if (timer >= DeathTime)
			{
				Destroy(gameObject);
			}
	}
}
