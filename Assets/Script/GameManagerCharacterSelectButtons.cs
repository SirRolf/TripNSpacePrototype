using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManagerCharacterSelectButtons : MonoBehaviour {

	public GameObject Player;
	public GameObject PlayerPreview;

	public Sprite Char1;
	public Sprite Char2;
	public Sprite Char3;
	public Sprite Char4;

	public void ChangeToChar1 ()
	{
		PlayerPrefs.SetFloat ("CharacterSprite", 1);
		Player.gameObject.GetComponent<SpriteRenderer>().sprite = Char1;
		PlayerPreview.gameObject.GetComponent<SpriteRenderer>().sprite = Char1;
	}
	public void ChangeToChar2 ()
	{
		PlayerPrefs.SetFloat ("CharacterSprite", 2);
		Player.gameObject.GetComponent<SpriteRenderer>().sprite = Char2;
		PlayerPreview.gameObject.GetComponent<SpriteRenderer>().sprite = Char2;
	}
	public void ChangeToChar3 ()
	{
		PlayerPrefs.SetFloat ("CharacterSprite", 3);
		Player.gameObject.GetComponent<SpriteRenderer>().sprite = Char3;
		PlayerPreview.gameObject.GetComponent<SpriteRenderer>().sprite = Char3;
	}
	public void ChangeToChar4 ()
	{
		PlayerPrefs.SetFloat ("CharacterSprite", 4);
		Player.gameObject.GetComponent<SpriteRenderer>().sprite = Char4;
		PlayerPreview.gameObject.GetComponent<SpriteRenderer>().sprite = Char4;
	}

	public void ChangeToGameScene (){
		SceneManager.LoadScene (1);
	}
}
