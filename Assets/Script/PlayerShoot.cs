using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

	private GameObject MainShot;
	public GameObject Bullet;
	public GameObject Lazer;

	public GameObject Torpedo;
	public AudioSource effectSource;
	public AudioClip clip;
	private float timer = 0;
	public float ShootDelay;

	public Sprite Orca_PowerupTriple;
	public Sprite Turtle_PowerupTriple;
	public Sprite Fish_PowerupTriple;
	public Sprite Jeli_PowerupTriple;
	void Awake(){
		if (1f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			MainShot = Lazer;
		}
		if (1f != PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			MainShot = Bullet;
		}
		effectSource = GameObject.FindGameObjectWithTag("effectSource").GetComponent<AudioSource>();
	}




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
			effectSource.clip = clip;
			effectSource.Play();

		//triple powerup
		if (this.gameObject.GetComponent<SpriteRenderer>().sprite == Orca_PowerupTriple|| this.gameObject.GetComponent<SpriteRenderer>().sprite == Turtle_PowerupTriple || this.gameObject.GetComponent<SpriteRenderer>().sprite == Fish_PowerupTriple|| this.gameObject.GetComponent<SpriteRenderer>().sprite == Jeli_PowerupTriple) {
			Vector3 spawnPosition1 = new Vector3(transform.position.x, transform.position.y + 1.5f, 0);
			if (MainShot == Lazer) {
				spawnPosition1 = new Vector3(transform.position.x, transform.position.y + 2.5f, 0);
			}
			Vector3 spawnPosition2 = new Vector3(transform.position.x - 0.9f, transform.position.y, 0);
			Vector3 spawnPosition3 = new Vector3(transform.position.x + 0.9f, transform.position.y, 0);
			Instantiate(MainShot, spawnPosition1, Quaternion.identity);
			Instantiate(Torpedo, spawnPosition2, Quaternion.identity);
			Instantiate(Torpedo, spawnPosition3, Quaternion.identity);
			timer = 0;
		}
		//normal
		else{
			Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + 1.5f, 0);
			if (MainShot == Lazer) {
				spawnPosition = new Vector3(transform.position.x, transform.position.y + 2.5f, 0);
			}
			Instantiate(MainShot, spawnPosition, Quaternion.identity);
			timer = 0;
		}
	}
}
