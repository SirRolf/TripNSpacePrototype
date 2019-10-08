using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public float timer;

	SpriteRenderer rend;

	void Start () {
		rend = GetComponent<SpriteRenderer> ();
		StartCoroutine ("FadeOut");
	}


	IEnumerator FadeOut()
	{
		for (float f = 1f; f >= -0.05f; f -= 0.05f) {
			Color c = rend.material.color;
			c.a = f;
			rend.material.color = c;
			yield return new WaitForSeconds (0.05f);
		}
	}

	public void startFading()
	{
		StartCoroutine ("FadeOut");
	}

	void Update()
	{
		timer += Time.deltaTime;
		if (timer >= 5) {
			Destroy(gameObject);
		}
	}
}
