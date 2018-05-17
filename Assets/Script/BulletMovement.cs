using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

	public float bulletSpeed;
	private float timer = 0;

	void Update () {
		timer += Time.deltaTime;
		transform.Translate(0, bulletSpeed, 0);
		if(timer >= 2)
		{
			Destroy(gameObject);
		}
	}
}
