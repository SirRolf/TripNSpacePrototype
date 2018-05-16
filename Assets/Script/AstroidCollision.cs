using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroidCollision : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log("collision");
	}
}
