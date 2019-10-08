using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour {

	public GameObject Player;
	private Transform Target;

	public float smoothSpeed;
	public Vector3 offset;

	void Start()
	{
		Player = GameObject.Find("Player");
		Target = Player.GetComponent<Transform> ();
	}

	void Update ()
	{
		transform.position = Vector3.Lerp(transform.position, Target.position + offset, smoothSpeed * Time.deltaTime);
	}
}
