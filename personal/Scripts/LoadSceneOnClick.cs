using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour {

	  public SliderVolume volume;




		public void loadByIndex(int sceneIndex)
		{
			SceneManager.LoadScene(sceneIndex);

		


		}
		}
