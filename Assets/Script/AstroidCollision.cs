using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			Destroy(gameObject);
			Destroy(col.gameObject);
		}
		
		if(col.gameObject.name == "DespawnZone")
		{
			Destroy(gameObject);
		}
	}
}
