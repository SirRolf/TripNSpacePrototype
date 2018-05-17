using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			Debug.Log (col.gameObject.tag);
			Destroy(gameObject);
			Destroy(col.gameObject);
		}
	}
}
