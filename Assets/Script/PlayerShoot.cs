using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	public GameObject Bullet;
	private float timer = 0;
	public float ShootDelay;

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
		Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, 0);
		Instantiate(Bullet, spawnPosition, Quaternion.identity);
		timer = 0;
	}
}
