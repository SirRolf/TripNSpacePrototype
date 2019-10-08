using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public GameObject smoke;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag != "Bullet")
		{
			Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, 0);
			Instantiate(smoke, spawnPosition, Quaternion.identity);
		}
	}
}
