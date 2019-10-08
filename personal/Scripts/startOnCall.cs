using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startOnCall : MonoBehaviour {

public GameObject caObjs;

public void Awake (){
	caObjs = GameObject.FindWithTag("canvasMainMenu");
	caObjs.GetComponent<Canvas>();

}



	}

	// Update is called once per frame
