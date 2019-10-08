using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public IEnumerator Shake (float duration, float magnitude)
	{
		Vector3 originalPos = transform.position;

		float elapsed = 0.0f;

		while (elapsed < duration) {
			float x = transform.position.x + Random.Range (-1.25f, 1.25f) * magnitude;
			float y = transform.position.y + Random.Range (-1.25f, 1.25f) * magnitude;

			transform.localPosition = new Vector3 (x, y, originalPos.z);

			elapsed += Time.deltaTime;

			yield return null;
		}

		transform.localPosition = originalPos;
	}
}
