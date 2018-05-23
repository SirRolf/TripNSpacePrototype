using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerHealth : MonoBehaviour {

	public int health = 11;

	public GameObject panelGameOver;

	public Image healthbar;

// dit is lelijk
	public Sprite a11;
	public Sprite a10;
	public Sprite a9;
	public Sprite a8;
	public Sprite a7;
	public Sprite a6;
	public Sprite a5;
	public Sprite a4;
	public Sprite a3;
	public Sprite a2;
	public Sprite a1;
	public Sprite a0;

	public Sprite[] sprites;

	void UpdateHealthUI () {
		if (health == 11) {
			//	healthbar.sprite = sprites[health]
			healthbar.sprite = a11;
		}
		if (health == 10) {
			healthbar.sprite = a10;
		}
		if (health == 9) {
			healthbar.sprite = a9;
		}
		if (health == 8) {
			healthbar.sprite = a8;
		}
		if (health == 7) {
			healthbar.sprite = a7;
		}
		if (health == 6) {
			healthbar.sprite = a6;
		}
		if (health == 5) {
			healthbar.sprite = a5;
		}
		if (health == 4) {
			healthbar.sprite = a4;
		}
		if (health == 3) {
			healthbar.sprite = a3;
		}
		if (health == 2) {
			healthbar.sprite = a2;
		}
		if (health == 1) {
			healthbar.sprite = a1;
		}
		if (health == 0) {
			healthbar.sprite = a0;
		}
	}

	void Update()
	{
		float reset = Input.GetAxisRaw("Reset");

		if(reset == 1)
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		if (health <= 0)
		{
			GameOver();
		}
	}

	public void GameOver()
	{
		panelGameOver.SetActive(true);
	}

	public void TakeDamage(int damage)
	{
		health -= damage;
		UpdateHealthUI();
	}
}
