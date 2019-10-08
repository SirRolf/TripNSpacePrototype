using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour {
//Music


public Slider Volume;
public Slider Volume1;

public AudioSource myMusic;
public AudioSource myMusic1;
public AudioSource myMusic2;
public AudioSource myMusic3;
//Effects
public AudioClip clip;
public AudioClip clip1;


	void Awake(){

		myMusic = GameObject.FindGameObjectWithTag("musicSource").GetComponent<AudioSource>();
		myMusic1 = GameObject.FindGameObjectWithTag("effectSource").GetComponent<AudioSource>();
		myMusic2 = GameObject.FindGameObjectWithTag("effectSource2").GetComponent<AudioSource>();
		myMusic3 = GameObject.FindGameObjectWithTag("effectSource3").GetComponent<AudioSource>();

	}
	// Update is called once per frame
	void Update () {
		//Music

		myMusic.volume = Volume.value;
		myMusic1.volume = Volume1.value;
		myMusic2.volume = Volume1.value;
		myMusic3.volume = Volume1.value;

		Debug.Log(Volume);
		//Effects



	}
}
