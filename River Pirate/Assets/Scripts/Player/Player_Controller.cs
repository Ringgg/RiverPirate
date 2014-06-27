using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player_Controller : MonoBehaviour {

	public int life;
	public float speed;
	public float position;
	public int shorecrash;
	public List<Mesh> meshes = new List<Mesh> ();
	private float mysz;
	private int res;
	private GameObject betterPlace;

	void Start () {
		betterPlace = GameObject.Find ("Moving");
		res = Screen.width;
		life = meshes.Count;
		position = 0;
		shorecrash = 30;
	}

	void FixedUpdate () {

		if (life == 0){
			Debug.Log ("restart");
			Application.LoadLevel(Application.loadedLevel);
		}
		if (life > meshes.Count)
			life = meshes.Count;

		gameObject.GetComponent<MeshFilter>().mesh = meshes[meshes.Count -life];
		gameObject.GetComponent<MeshCollider> ().sharedMesh = meshes[meshes.Count -life];

		PositionChanging ();
		shorecrash++;
	}


	void PositionChanging () {
		mysz = Input.mousePosition.x;
		position =  -80 * mysz/res + 40;
		if (position > 20)
			position = 20;
		if (position < -20)
			position = -20;
		if (shorecrash < 20)
			position = 0;
		transform.position = Vector3.Lerp(transform.position, new Vector3(betterPlace.transform.position.x,1,position), speed * Time.deltaTime );
	}
}


