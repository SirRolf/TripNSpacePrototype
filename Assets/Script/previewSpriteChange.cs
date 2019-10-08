using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class previewSpriteChange : MonoBehaviour {

	public Sprite char1;
	public Sprite char2;
	public Sprite char3;
	public Sprite char4;

	void Update () {
		if (1f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = char1;
		}
		if (2f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = char2;
		}
		if (3f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = char3;
		}
		if (4f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = char4;
		}
	}
}
