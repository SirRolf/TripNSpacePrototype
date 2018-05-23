using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidCollision : MonoBehaviour {

	public GameObject manager;

	public int damage = 1;

	public int health;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			health--;
			Destroy(col.gameObject);
		}
		if(health == 0)
		{
			Destroy(gameObject);
		}
		if(col.gameObject.name == "DespawnZone")
		{
			Destroy(gameObject);
		}

		if(col.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			manager.GetComponent<GameManagerHealth>().TakeDamage(damage);
		}
	}
}
