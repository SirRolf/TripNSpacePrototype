using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text text;
	public Text Highscore;

	public GameObject Health;

	private float scoreMultiplier;

	private float score;



	void Update () {
		text.text = ""+Mathf.Floor (score);

		Highscore.text = PlayerPrefs.GetFloat ("HighScore", 0).ToString ();
	}


	public void AddScore(float add)
	{
		if (Health.GetComponent<GameManagerHealth> ().gameOver == false) {
			score += add;
		}
	}

	public void UpdateHighScore(){
		if (score > PlayerPrefs.GetFloat ("HighScore", 0)) {
			PlayerPrefs.SetFloat ("HighScore", score);
		}
	}
}
