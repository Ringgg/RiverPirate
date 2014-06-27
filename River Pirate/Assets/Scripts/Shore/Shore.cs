using UnityEngine;
using System.Collections;

public class Shore : MonoBehaviour {
	private GameObject gui;
	private float Speed;
	private GameObject betterPlace;
	void Start () {
		betterPlace = GameObject.Find ("Moving");
		gui = GameObject.Find ("GUI");
		Speed = gui.GetComponent<settings>().speed;
	}

	void FixedUpdate () {
		if (transform.position.x - betterPlace.transform.position.x <= -200)
			if (transform.rotation.y == 0)
				transform.Translate (new Vector3(400,0,0));
			else
				transform.Translate (new Vector3(-400,0,0));
		//gameObject.transform.Translate (-Speed * Time.deltaTime,0,0);
	}
}
