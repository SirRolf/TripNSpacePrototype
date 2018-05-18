using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSpawner : MonoBehaviour {

	public GameObject astroid_1;
	public GameObject astroid_2;
	public GameObject astroid_3;
	public GameObject powerup_triple;
	private float PlayerPosx;
	private float PlayerPosy;

	public float spawnRateAstroids= 1f;
	public float spawnRatePowerup= 20f;

//for choosing the astroid/powerup
	private int picker;

	//timers
	private float timerAstroid = 0;
	private float timerPowerUp = 0;

	void Update () {

		// update check

		//player position
		PlayerPosx = GameObject.Find("Player").transform.position.x;
		PlayerPosy = GameObject.Find("Player").transform.position.y;

		//timer updater
		timerAstroid += Time.deltaTime;
		timerPowerUp += Time.deltaTime;

		//for spawning in astroids

		if (timerAstroid >= spawnRateAstroids)
		{
			//picks a random astroid
			picker = Random.Range(1, 10);
			if(picker == 1 || picker == 2 || picker == 3)
			{
				Spawnastroid_1();
			}
			if(picker == 4 || picker == 5 || picker == 6 || picker == 7)
			{
				Spawnastroid_2();
			}
			if(picker == 8 || picker == 9 || picker == 10)
			{
				Spawnastroid_3();
			}

			timerAstroid = 0;
		}

		// For spawning the powerups in

		if (timerPowerUp >= spawnRatePowerup)
		{
			picker = 1;

			if(picker == 1)
			{
				SpawnTriple();
			}

			timerPowerUp = 0;
		}

	}

//astroid spawning
	private void Spawnastroid_1()
	{
		Vector3 spawnPosition1 = new Vector3(Random.Range(PlayerPosx + -10.0f,PlayerPosx + 35.0f), PlayerPosy + 12.5f, 0);
		Instantiate(astroid_1, spawnPosition1, Quaternion.identity);
		Vector3 spawnPosition2 = new Vector3(Random.Range(PlayerPosx + 45.0f,PlayerPosx + 35.0f), PlayerPosy + 6.5f, 0);
		Instantiate(astroid_1, spawnPosition2, Quaternion.identity);
		Vector3 spawnPosition3 = new Vector3(Random.Range(PlayerPosx + -10.0f,PlayerPosx + -20.0f), PlayerPosy + 6.5f, 0);
		Instantiate(astroid_1, spawnPosition3, Quaternion.identity);
	}
	private void Spawnastroid_2()
	{
		Vector3 spawnPosition1 = new Vector3(Random.Range(PlayerPosx + -12.0f, PlayerPosx + 12.0f), PlayerPosy + 12.5f, 0);
		Instantiate(astroid_2, spawnPosition1, Quaternion.identity);
		Vector3 spawnPosition2 = new Vector3(Random.Range(PlayerPosx + 17.0f, PlayerPosx + 12.0f), PlayerPosy + 6.5f, 0);
		Instantiate(astroid_2, spawnPosition2, Quaternion.identity);
		Vector3 spawnPosition3 = new Vector3(Random.Range(PlayerPosx + -17.0f, PlayerPosx + -12.0f), PlayerPosy + 6.5f, 0);
		Instantiate(astroid_2, spawnPosition3, Quaternion.identity);
	}
	private void Spawnastroid_3()
	{
		Vector3 spawnPosition1 = new Vector3(Random.Range(PlayerPosx + -12.0f, PlayerPosx + 12.0f),PlayerPosy + 12.5f, 0);
		Instantiate(astroid_3, spawnPosition1, Quaternion.identity);
		Vector3 spawnPosition2 = new Vector3(Random.Range(PlayerPosx + 17.0f, PlayerPosx + 12.0f),PlayerPosy + 6.5f, 0);
		Instantiate(astroid_3, spawnPosition2, Quaternion.identity);
		Vector3 spawnPosition3 = new Vector3(Random.Range(PlayerPosx + -17.0f, PlayerPosx + -12.0f),PlayerPosy + 6.5f, 0);
		Instantiate(astroid_3, spawnPosition3, Quaternion.identity);
	}

	private void SpawnTriple()
	{
		Vector3 spawnPosition1 = new Vector3(Random.Range(PlayerPosx + -12.0f, PlayerPosx + 12.0f),PlayerPosy + 12.5f, 0);
		Instantiate(powerup_triple, spawnPosition1, Quaternion.identity);
		print("triple spawned");
	}
}
