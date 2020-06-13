﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionWithCamera : MonoBehaviour {

    // public GameObject MainCamera;
	public bool zombieIsThere;
	float timer;
	int timeBetweenAttack;

	// Use this for initialization
	void Start () {
		timeBetweenAttack = 2;
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (zombieIsThere && timer >= timeBetweenAttack) 
		{
			Attack ();
		}
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "ARCamera") 
		{
			zombieIsThere = true;
		}
	}

	void OnCollisionExit (Collision col)
	{
		if (col.gameObject.tag == "ARCamera") 
		{
			zombieIsThere = false;
		}
	}

	void Attack()
	{
		timer = 0f;
		GetComponent<Animator> ().Play ("Z_Attack");
	}
}
