using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	public GameObject Bullet;
	private float timer = 0;
	public float ShootDelay;

	public Sprite PowerupTriple;

	void Update () {
		timer += Time.deltaTime;
		float SpaceBar = Input.GetAxisRaw("SpaceBar");

		if(SpaceBar == 1 && timer >= ShootDelay)
		{
			Shoot();
		}
	}

	void Shoot()
	{
		//list of powerups

		//triple powerup
		if (this.gameObject.GetComponent<SpriteRenderer>().sprite == PowerupTriple) {
			Vector3 spawnPosition1 = new Vector3(transform.position.x, transform.position.y, 0);
			Vector3 spawnPosition2 = new Vector3(transform.position.x - 0.4f, transform.position.y, 0);
			Vector3 spawnPosition3 = new Vector3(transform.position.x + 0.4f, transform.position.y, 0);
			Instantiate(Bullet, spawnPosition1, Quaternion.identity);
			Instantiate(Bullet, spawnPosition2, Quaternion.identity);
			Instantiate(Bullet, spawnPosition3, Quaternion.identity);
			timer = 0;
		}
		//normal
		else{
			Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, 0);
			Instantiate(Bullet, spawnPosition, Quaternion.identity);
			timer = 0;
		}
	}
}
