using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorControler : MonoBehaviour {

	public GameObject player;

	public Animator animator;

	private float timer;
	public float ShootDelay;

	void Start()
	{
		ShootDelay = player.GetComponent<PlayerShoot>().ShootDelay;
	}

	void Update(){
		timer += Time.deltaTime;
		float SpaceBar = Input.GetAxisRaw("SpaceBar");

		if(SpaceBar == 1 && timer >= ShootDelay)
		{
			animator.SetBool ("IsShooting", true);
		}
		if(SpaceBar == 0 && timer >= ShootDelay)
		{
			animator.SetBool ("IsShooting", false);
		}
	}
}
