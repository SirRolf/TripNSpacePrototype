using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPassive : MonoBehaviour {

	//all other variables

	//all orca variables

	//all turtle variables
	public GameObject TurtleShield;

	public float ShieldChargeTime = 10;

	private float timerShield;
	private bool TurtleShieldOn;

	//all fish variables
	public float fishAbilityTime = 5;
	public FishState state = FishState.Normal;
	private float timerFish = 10;
	private SpriteRenderer renderer;
	private float ActiveTimerFish;
	private bool FishShouldCount;
	public GameObject readyEffectFish;

	//all jelli variables
	private float timerjelli = 20;
	public float jelliAbilityTime = 15;
	public GameObject discharge;
	public GameObject readyEffectJelli;

	void Start () {
		//shield is on if it is 1 else 0
		PlayerPrefs.SetFloat ("TurtleShield", 0);
		renderer = GetComponent<SpriteRenderer> ();
	}

	void Update () {
		float Activation = Input.GetAxisRaw("Active");

		//check What Character the player is
		if (1f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			
		}
		if (2f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {

			//checks if shield is up
			if (1 == PlayerPrefs.GetFloat ("TurtleShield", 0)) {
				TurtleShield.SetActive (true);
			} else {
				TurtleShield.SetActive (false);
			}


			//checks if the player was hit
			if (TurtleShieldOn == true && 1f == PlayerPrefs.GetFloat ("TurtleShield", 0)){
				timerShield = 0;
			}
			//updates the timer
			else if (timerShield < ShieldChargeTime) {
				timerShield += Time.deltaTime;
			}
			//turns on shield
			else if (timerShield > ShieldChargeTime) {
				timerShield = ShieldChargeTime + 0.01f;
				PlayerPrefs.SetFloat ("TurtleShield", 1);
				TurtleShieldOn = true;
			}
		}
		if (3f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			timerFish += Time.deltaTime;
			if (timerFish > fishAbilityTime) {
				readyEffectFish.SetActive (true);
			} else {
				readyEffectFish.SetActive (false);
			}

			if(Activation == 1 && timerFish > fishAbilityTime)
			{
				state = FishState.Submerged;
				FishShouldCount = true;
			}

			if(FishShouldCount == true){
				ActiveTimerFish += Time.deltaTime;
			}

			FishActive ();
		}
		if (4f == PlayerPrefs.GetFloat ("CharacterSprite", 0)) {
			timerjelli += Time.deltaTime;
			if (timerjelli > jelliAbilityTime) {
				readyEffectJelli.SetActive (true);
			} else {
				readyEffectJelli.SetActive (false);
			}
			if(Activation == 1 && timerjelli > jelliAbilityTime)
			{
				Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, 0);
				Instantiate(discharge, spawnPosition, Quaternion.identity);
				timerjelli = 0;
			}
		}


		//veranderingen per state
		if (state == FishState.Normal) {
			//turns on shooting when not in submerged state
			this.GetComponent<PlayerShoot> ().enabled = true;
			this.GetComponent<BoxCollider2D> ().enabled = true;
			Color current = renderer.color;
			Color c = new Color(
				Mathf.Lerp(current.r, 1f, 0.1f),
				Mathf.Lerp(current.g, 1f, 0.1f),
				Mathf.Lerp(current.b, 1f, 0.1f)
			);
			renderer.color = c;
			Vector3 currentV = this.gameObject.transform.localScale;
			Vector3 v = new Vector3 (
				Mathf.Lerp(currentV.x, 0.15f, 0.02f),
				Mathf.Lerp(currentV.y, 0.15f, 0.02f)
			);
			this.gameObject.transform.localScale = v;
		} else if (state == FishState.Submerged) {
			//turns off shooting when in submerged state
			this.GetComponent<PlayerShoot> ().enabled = false;
			this.GetComponent<BoxCollider2D> ().enabled = false;
			Color current = renderer.color;
			Color c = new Color(
				Mathf.Lerp(current.r, 0.3f, 0.1f),
				Mathf.Lerp(current.g, 0.3f, 0.1f),
				Mathf.Lerp(current.b, 0.3f, 0.1f)
			);
			renderer.color = c;
			Vector3 currentV = this.gameObject.transform.localScale;
			Vector3 v = new Vector3 (
				Mathf.Lerp(currentV.x, 0.075f, 0.02f),
				Mathf.Lerp(currentV.y, 0.075f, 0.02f)
			            );
			this.gameObject.transform.localScale = v;
		}
	}

	void FishActive(){
		//reset to normal when timer runs out
		if(ActiveTimerFish > 1.5f){
			print ("Fish Ability over");
			state = FishState.Normal;
			ActiveTimerFish = 0;
			timerFish = 0;
			FishShouldCount = false;
		}
	}
}

public enum FishState{
	Normal,
	Submerged
}