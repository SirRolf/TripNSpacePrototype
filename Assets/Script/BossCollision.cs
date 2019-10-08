using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCollision : MonoBehaviour {

	public GameObject manager;

	private GameObject score;

	public GameObject explosion;

	public int damage;

	public float scoreReward;

	void Start()
	{
		score = GameObject.Find ("Score");
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "Player")
		{
			manager.GetComponent<GameManagerHealth>().TakeDamage(damage);
		}

		if (col.gameObject.tag == "Bullet") {
			Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y - 0.4f, 0);
			Instantiate(explosion, spawnPosition, Quaternion.identity);
			score.GetComponent<Score>().AddScore (scoreReward);
			Destroy(gameObject);
			Destroy (col.gameObject);
		}
		if(col.gameObject.tag == "JelliAbil")
		{
			Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y - 0.4f, 0);
			Instantiate(explosion, spawnPosition, Quaternion.identity);
			score.GetComponent<Score>().AddScore (scoreReward);
			Destroy(gameObject);
		}
	}
}
