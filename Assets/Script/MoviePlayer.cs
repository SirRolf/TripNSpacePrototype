using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviePlayer : MonoBehaviour {



	public MovieTexture movieTexture;
	// Use this for initialization
	void Awake () {
		if(movieTexture != null){
			movieTexture.Play();
			Screen.fullScreen = true;
		}
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp(KeyCode.Escape)){
			Screen.fullScreen = false;
			movieTexture.Stop();
		}

	}

	void OnGUI(){
		if(movieTexture != null && movieTexture.isPlaying){
			GUI.DrawTexture(new Rect(0,0, Screen.width , Screen.height), movieTexture, ScaleMode.StretchToFill);
		}
	}
}
