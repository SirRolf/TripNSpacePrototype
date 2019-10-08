using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSprite : MonoBehaviour {
	public Sprite Orca_PowerUp;
	public Sprite Turtle_PowerUp;
	public Sprite Fish_PowerUp;
	public Sprite Jelly_PowerUp;

	void Awake(){
		if (1f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = Orca_PowerUp;
		}
		if (2f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = Turtle_PowerUp;
		}
		if (3f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = Fish_PowerUp;
		}
		if (4f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = Jelly_PowerUp;
		}
	}
}
