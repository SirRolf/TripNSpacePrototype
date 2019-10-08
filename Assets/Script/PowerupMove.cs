using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupMove : MonoBehaviour {

	public bool ChangeForPlayer = false;
	public bool doesRotate = false;
	public float moveSpeedMin = 0.1f;
	public float moveSpeedMax = 0.2f;

	public float rotateSpeedMin = 1f;
	public float rotateSpeedMax = 2f;

	private float moveSpeed;
	private float rotationSpeed;

	public Sprite Orca_Wings;
	public Sprite Turtle_Wings;
	public Sprite Fish_Wings;
	public Sprite Jeli_Wings;

	void Start()
	{
		moveSpeed = Random.Range(moveSpeedMin, moveSpeedMax);
		rotationSpeed = Random.Range(rotateSpeedMin, rotateSpeedMax);
		if (Jeli_Wings == true) {
			if (1f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = Orca_Wings;	
			}
			if (2f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = Turtle_Wings;	
			}
			if (3f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = Fish_Wings;	
			}
			if (4f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
				this.gameObject.GetComponent<SpriteRenderer>().sprite = Jeli_Wings;	
			}
		}
	}

	void Update () {
		transform.Translate(0, -moveSpeed, 0);
		if (doesRotate == true) {
			transform.Rotate(0, 0, rotationSpeed);
		}
	}
}
