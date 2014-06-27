using UnityEngine;
using System.Collections;

public class obst_shore : MonoBehaviour {
	private GameObject gui;
	private float Speed;
	private bool ZderzylSie;
	private Player_Controller kontroller;
	void Start () {
		ZderzylSie = false;
		gui = GameObject.Find ("GUI");
		Speed = gui.GetComponent<settings>().speed;
		rigidbody.AddForce (Vector3.left, ForceMode.Impulse);
		transform.Rotate (270, 0, 0);
		if (transform.position.z == 20)
			transform.Rotate (0, 0, 180);
	}
	void OnCollisionEnter (Collision col)
	{
		if (!ZderzylSie)
		{
			kontroller = col.gameObject.GetComponent<Player_Controller>();
			kontroller.life -=1;
			kontroller.shorecrash = 0;
		}
		Debug.Log ("zderzenie");
		ZderzylSie = true;
	}
	void FixedUpdate () {
		
		rigidbody.AddForce (Vector3.left * 0.0001f, ForceMode.Acceleration);
		//if (transform.position.x < -100)
		Destroy (gameObject, 10f);
	}
}
