using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class player_controller_backup : MonoBehaviour {
	public int res;
	public int life;
	public float speed;
	public int position;
	Vector3 [] lines = {new Vector3(0,1,-20),new Vector3(0,1,-10),new Vector3(0,1,0),new Vector3(0,1,10),new Vector3(0,1,20)};
	public List<Mesh> meshes = new List<Mesh> ();
	
	void Start () {
		res = Screen.width;
		life = meshes.Count;
		position = 2;
		speed = 5f;
	}
	
	
	void Update () {
		if (life == 0){
			Debug.Log ("restart");
			Application.LoadLevel(Application.loadedLevel);
		}
		if (life > meshes.Count)
			life = meshes.Count;
		//ciezki dla maszyny kawalek - w wolnym czasie poprawic
		gameObject.GetComponent<MeshFilter>().mesh = meshes[meshes.Count -life];
		gameObject.GetComponent<MeshCollider> ().sharedMesh = meshes[meshes.Count -life];
		PositionChanging ();
	}
	
	
	void PositionChanging () {
		if(Input.GetKeyDown("d") && position > 0)
			position--;
		if(Input.GetKeyDown("a") && position < 4)
			position++;
		transform.position = Vector3.Lerp(transform.position, lines[position], speed * Time.deltaTime );
	}
}


