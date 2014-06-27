using UnityEngine;
using System.Collections;

public class shore_spawner : MonoBehaviour {

	public GameObject ShoreMesh;
	private float Speed;
	private Vector3 vec;
	private Quaternion qua;
	private GameObject gui;

	void Start () {
		gui = GameObject.Find ("GUI");
		Speed = gui.GetComponent<settings>().speed;
		vec = transform.position;
		qua = transform.rotation;
		InvokeRepeating("Spawn",75f/Speed ,100f/Speed);
	}
	void Spawn ()
	{
		Instantiate(ShoreMesh, vec, qua);
	}
}
