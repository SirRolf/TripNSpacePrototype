﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {


	// Use this for initialization
	void Awake () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
		if(objs.Length > 1){


			Destroy(this.gameObject);

}
   GameObject[] effObjs = GameObject.FindGameObjectsWithTag("effectSource");
   if(effObjs.Length > 1){
	 Destroy(this.gameObject);
}

  GameObject[] muObjs = GameObject.FindGameObjectsWithTag("musicSource");
  if(muObjs.Length > 1){
  Destroy(this.gameObject);
}

	GameObject[] effObjs2 = GameObject.FindGameObjectsWithTag("effectSource2");
	if(effObjs2.Length > 1){
	Destroy(this.gameObject);
}
	GameObject[] effObjs3 = GameObject.FindGameObjectsWithTag("effectSource3");
	if(effObjs3.Length > 1){
		Destroy(this.gameObject);
}





		DontDestroyOnLoad(this.gameObject);






}

}
