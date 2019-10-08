using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Awaken : MonoBehaviour {



	 public GameObject aPanel ;
	 public SliderVolume musicManager;
	 public AudioClip clip;
	// Use this for initialization
	void Awake () {





		musicManager = GameObject.FindGameObjectWithTag("music").GetComponent<SliderVolume>();
		musicManager.Volume = GameObject.FindGameObjectWithTag("Slider").GetComponent<Slider>();
		musicManager.Volume1 = GameObject.FindGameObjectWithTag("Slider1").GetComponent<Slider>();

		musicManager.Volume.value = musicManager.myMusic.volume;
		musicManager.Volume1.value = musicManager.myMusic1.volume;

		musicManager.myMusic.clip = clip;
		musicManager.myMusic.Play();

		Debug.Log(musicManager.Volume);



		aPanel.SetActive(false);





	}

	// Update is called once per frame
	void Update () {

	}
}
