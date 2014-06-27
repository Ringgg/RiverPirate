using UnityEngine;
using System.Collections;

public class camera_test : MonoBehaviour {

	private GameObject gui;
	private float Speed;
	// Use this for initialization
	void Start () {
	gui = GameObject.Find ("GUI");
	Speed = gui.GetComponent<settings>().speed;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(Speed*Time.deltaTime,0,0);
	}
}
//(Mathf.Sin(5 * Time.time))/3