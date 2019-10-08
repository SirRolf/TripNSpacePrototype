using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dischargeHitboxEnlarger : MonoBehaviour {
	// Update is called once per frame
	private float timer;

	void Update () {
		timer += Time.deltaTime;

		float r = Mathf.Lerp (0, 3.6f, 1f);
		this.gameObject.GetComponent<CircleCollider2D> ().radius = r;

		if (timer > 1f)
		{
			Destroy (gameObject);
		}

	}
}
