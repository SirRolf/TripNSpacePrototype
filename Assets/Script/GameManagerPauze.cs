using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerPauze : MonoBehaviour {

	public GameObject pPanel;



	public GameObject Player;

	private float timer = 1;

	private bool pauseScreenActive = false;



	void Update () {

		timer += Time.deltaTime;

		float escape = Input.GetAxisRaw("Escape");

		if (escape == 1 && timer > 1 && pauseScreenActive == false) {
			pPanel.SetActive (true);




			timer = 0;
			pauseScreenActive = true;
			Time.timeScale = 0.25f;
			Player.GetComponent<PlayerMove> ().enabled = false;
			Player.GetComponent<PlayerShoot> ().enabled = false;
		}
		if (escape == 1 && timer > 0.25f && pauseScreenActive == true) {
			pPanel.SetActive(false);


			timer = 0;
			pauseScreenActive = false;
			Time.timeScale = 1;
			Player.GetComponent<PlayerMove> ().enabled = true;
			Player.GetComponent<PlayerShoot> ().enabled = true;
		}


	}

}
