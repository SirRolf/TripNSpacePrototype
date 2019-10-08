using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidCollision : MonoBehaviour {

	public GameObject manager;

	public GameObject score;

	public GameObject explosion;
	public GameObject Hit;

	public float damage = 1;

	public int astroidType;

	public int health;

	public float scoreReward;

	public float minScale;
	public float maxScale;
	private float scale;

	void Start ()
	{
		score = GameObject.Find ("Score");
		scale = Random.Range (minScale, maxScale);
		transform.localScale = new Vector3(scale, scale, 0);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + -0.2f, 0);
			Instantiate(Hit, spawnPosition, Quaternion.identity);
			health--;
			if (1f != PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
				Destroy(col.gameObject);
			}
		}
		if(col.gameObject.tag == "JelliAbil")
		{
			Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + -0.2f, 0);
			Instantiate(Hit, spawnPosition, Quaternion.identity);
			health--;
			health--;
		}
		if(health <= 0)
		{
			Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y - 0.4f, 0);
			Instantiate(explosion, spawnPosition, Quaternion.identity);
			score.GetComponent<Score>().AddScore (scoreReward);
			Destroy(gameObject);
		}
		if(col.gameObject.tag == "Despawn")
		{
			Destroy(gameObject);
		}

		if(col.gameObject.tag == "Player")
		{
			//checks if the turtle shield is turned on, created in the PlayerPassive.cs script
			if (1 == PlayerPrefs.GetFloat ("TurtleShield", 0)) {
				Destroy (gameObject);
				PlayerPrefs.SetFloat ("TurtleShield", 0);
				damage = damage * 0.5f;
				manager.GetComponent<GameManagerHealth>().TakeDamage(Mathf.Round(damage));
			} else {
				Destroy (gameObject);
				manager.GetComponent<GameManagerHealth>().TakeDamage(damage);
			}
		}
	}
}
