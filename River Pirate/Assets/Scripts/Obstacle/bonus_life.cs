﻿using UnityEngine;
using System.Collections;

public class bonus_life : MonoBehaviour {
	private GameObject gui;
	private float Speed;
	void Start () {
		gui = GameObject.Find ("GUI");
		Speed = gui.GetComponent<settings>().speed;
		rigidbody.AddForce (Vector3.left, ForceMode.Impulse);
	}
	void OnCollisionEnter (Collision col)
	{
		Player_Controller pc = col.gameObject.GetComponent<Player_Controller>();
        if (pc != null)
        {
            pc.GetDamage(-1); //heals
        }
		Destroy (gameObject);
		//Debug.Log ("bonus_hp");
	}
	void FixedUpdate () {
		//rigidbody.AddForce (Vector3.left * Speed, ForceMode.Acceleration);
		//if (transform.position.x < -50)
		Destroy (gameObject, 10f);
	}
}
