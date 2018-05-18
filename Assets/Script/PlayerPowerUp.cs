using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour {

	public Sprite PowerupTriple;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.name == "PowerUpTriple(Clone)")
		{
			this.gameObject.GetComponent<SpriteRenderer>().sprite = PowerupTriple;
			Destroy(col.gameObject);
		}
	}
}
