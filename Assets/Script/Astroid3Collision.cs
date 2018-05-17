using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid3Collision : MonoBehaviour {

	public int health;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			Debug.Log (col.gameObject.tag);
			health--;
			Destroy(col.gameObject);
		}
		if(health == 0)
		{
			Destroy(gameObject);
		}
	}
}
