using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour {

	public GameObject manager;

	private bool pickedUp = false;

	public Sprite Normal;
	public Sprite PowerupTriple;

	public Sprite Orca_Main;
	public Sprite Orca_Wings;
	public Sprite Turtle_Main;
	public Sprite Turtle_Wings;
	public Sprite Fish_Main;
	public Sprite Fish_Wings;
	public Sprite jeli_Main;
	public Sprite jeli_Wings;

	private float timer;
	public float timeoutTriple;


	void Start()
	{
		Normal = this.gameObject.GetComponent<SpriteRenderer> ().sprite;

		if (Normal == Orca_Main) {
			PowerupTriple = Orca_Wings;
		}
		if (Normal == Turtle_Main) {
			PowerupTriple = Turtle_Wings;
		}
		if (Normal == Fish_Main) {
			PowerupTriple = Fish_Wings;
		}
		if (Normal == jeli_Main) {
			PowerupTriple = jeli_Wings;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.name == "PowerUpTriple(Clone)")
		{
			pickedUp = true;
			manager.GetComponent<GameManagerHealth>().TakeDamage(0);
			this.gameObject.GetComponent<SpriteRenderer>().sprite = PowerupTriple;
			Vector3 gone = new Vector3 (100, 0, 10);
			col.transform.position = gone;
		}
		if(col.gameObject.name == "PowerUpHealth(Clone)")
		{
			manager.GetComponent<GameManagerHealth>().TakeDamage(-5);
			Destroy(col.gameObject);
		}
	}

	void Update()
		{
		if (pickedUp == true) {
			timer += Time.deltaTime;
			if (timer >= timeoutTriple) {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
				timer = 0;
				pickedUp = false;
				}
			}
		}
}
