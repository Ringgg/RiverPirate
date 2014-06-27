using UnityEngine;
using System.Collections;

public class bonus_score : MonoBehaviour {
	private float Speed;
	private GameObject gui;
	void Start () {
		gui = GameObject.Find ("GUI");
		Speed = gui.GetComponent<settings>().speed;
		rigidbody.AddForce (Vector3.left, ForceMode.Impulse);
	}
	void OnCollisionEnter (Collision col)
	{
		gui.GetComponent<gui>().x +=100;
		Destroy (gameObject);
		//Debug.Log ("bonus_pkt");
	}
	void FixedUpdate () {
		//rigidbody.AddForce (Vector3.left * Speed, ForceMode.Acceleration);
		//if (transform.position.x < -50)
			Destroy (gameObject, 10f);
	}
}
