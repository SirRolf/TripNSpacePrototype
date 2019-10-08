using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerHealth : MonoBehaviour {

	public float health = 11;

	public float timer;
	private float GameOverTimer;

	public float invinciTime;
	public bool invinciTrue;
	public float time2;
	public bool isDead = false;

	public GameObject panelGameOver;
	public GameObject score;

	public AudioSource source1;

	public GameObject deathBoom;

	public GameObject Player;

	public CameraShake cameraShake;

	public bool gameOver;

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

	void Start()

	{


		source1 = GameObject.FindGameObjectWithTag("effectSource2").GetComponent<AudioSource>();

		Time.timeScale = 1f;
	}

	void UpdateHealthUI () {
		if (health >= 11) {
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
		if (health <= 0) {
			healthbar.sprite = a0;
		}
	}


	void Update()
	{
		if(isDead == false){
			time2 = 0;
		} else{
			time2 = Time.deltaTime;
		}
		if(time2 == 4){

			Destroy(Player);

		}


		float reset = Input.GetAxisRaw("Reset");

		timer += Time.deltaTime;

		if (timer <= invinciTime) {
			invinciTrue = true;
		} else {
			invinciTrue = false;
		}

		if(reset == 1)
		{
			SceneManager.LoadScene(1);
		}
		if (health <= 0)
		{
			GameOver();
		}
	}

	public void GameOver()
	{
		GameOverTimer += Time.deltaTime;
		gameOver = true;
		panelGameOver.SetActive(true);
		score.GetComponent<Score>().UpdateHighScore();
		if(GameOverTimer > 3.7f)
		{
			Destroy(Player);
				Time.timeScale = 0.25f;
		}
		Player.GetComponent<PlayerMove> ().enabled = false;
		Player.GetComponent<PlayerShoot> ().enabled = false;
		Vector3 spawnPosition = new Vector3(Player.transform.position.x, Player.transform.position.y, 0);
		if (isDead == false)
		{
			Instantiate(deathBoom, spawnPosition, Quaternion.identity);
			isDead = true;
		}

	}

	public void TakeDamage(float damage)
	{
		if (invinciTrue == false || damage <= 0) {
			health -= damage;
			if (health >= 11) {
				health = 11;
			}
			source1.Play();
			UpdateHealthUI ();
			StartCoroutine (cameraShake.Shake (.15f, .4f));
			timer = 0f;
		}
	}


}
