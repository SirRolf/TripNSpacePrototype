using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalizeTimeScript : MonoBehaviour {


	public GameObject Player;





	public void normalizeTime(){
		Time.timeScale = 1f;
		Player.GetComponent<PlayerMove> ().enabled = true;
		Player.GetComponent<PlayerShoot> ().enabled = true;

	}
}
