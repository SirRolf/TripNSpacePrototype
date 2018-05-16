using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSpawner : MonoBehaviour {

	public GameObject astroid_1;
	public GameObject astroid_2;
	public GameObject astroid_3;
	public float spawnRate= 1f;

	private int picker;
	private float timer = 0;

	void Update () {
		timer += Time.deltaTime;
		if (timer >= spawnRate)
		{
			picker = Random.Range(1, 4);
			if(picker == 1)
			{
				Spawnastroid_1();
			}
			if(picker == 2)
			{
				Spawnastroid_2();
			}
			if(picker == 3)
			{
				Spawnastroid_3();
			}
		}
	}

	private void Spawnastroid_1()
	{
		Debug.Log("Spawn astroid1");

		Vector3 spawnPosition = new Vector3(Random.Range(-7.0f, 7.0f), 11, 0);
		Instantiate(astroid_1, spawnPosition, Quaternion.identity);

		timer = 0;
	}
	private void Spawnastroid_2()
	{
		Debug.Log("Spawn astroid2");

		Vector3 spawnPosition = new Vector3(Random.Range(-7.0f, 7.0f), 11, 0);
		Instantiate(astroid_2, spawnPosition, Quaternion.identity);

		timer = 0;
	}
	private void Spawnastroid_3()
	{
		Debug.Log("Spawn astroid3");

		Vector3 spawnPosition = new Vector3(Random.Range(-7.0f, 7.0f), 11, 0);
		Instantiate(astroid_3, spawnPosition, Quaternion.identity);

		timer = 0;
	}
}
