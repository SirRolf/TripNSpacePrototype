using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float rotationSpeed;
	public float moveSpeed;

	public Sprite Orca_main;
	public Sprite Turtle_main;
	public Sprite Fish_main;
	public Sprite Jeli_main;

	void Awake(){
		if (1f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = Orca_main;	
		}
		if (2f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = Turtle_main;	
		}
		if (3f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = Fish_main;	
		}
		if (4f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			this.gameObject.GetComponent<SpriteRenderer>().sprite = Jeli_main;	
		}
	}

	void Update () {

		float horizontal = Input.GetAxis("Horizontal");
		horizontal = horizontal * 0.75f;
		float vertical = Input.GetAxis("Vertical");
		Vector3 direction = new Vector3(horizontal, vertical, 0);

		if (direction.magnitude > 1)
			direction.Normalize();

		transform.Translate(direction * moveSpeed * Time.deltaTime);
		/*
		if(Vertical == 1)
		{
			transform.Translate(0, moveSpeed, 0);
		}
		else if(Vertical == -1)
		{
			transform.Translate(0, -moveSpeed, 0);
		}

		if(Horizontal == -1)
		{
			transform.Translate(-moveSpeed, 0, 0);
		}
		if(Horizontal == 1)
		{
			transform.Translate(moveSpeed, 0, 0);
			//transform.Rotate(rotationSpeed * Vector3.back * Time.deltaTime);
		}
		*/
	}
}
