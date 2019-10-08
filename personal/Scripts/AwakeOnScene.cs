using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeOnScene : MonoBehaviour {
	public GameObject caObjs;
	public Canvas caComp;
	public GameObject mPanel;
	// Use this for initialization
	void Start() {

//		GameObject.FindGameObjectWithTag("canvasMainMenu").SetActive(true);
	//	caObjs = GameObject.FindGameObjectWithTag("canvasMainMenu");
		//mPanel = GameObject.FindGameObjectWithTag("mainPanel");

		caObjs = GameObject.FindGameObjectWithTag("canvasMainMenu");

		mPanel = GameObject.FindGameObjectWithTag("mainPanel");
	//	Debug.Log(mPanel);
		caComp = caObjs.GetComponent<Canvas>();
		caComp.enabled = true;
		mPanel.SetActive(true);

	}

	void OnEnable()
	{
//		caObjs.SetActive(true);
//		mPanel.SetActive(true);
	}
	// Update is called once per frame
	void Update () {
		//mPanel.SetActive(true);
	}
}
