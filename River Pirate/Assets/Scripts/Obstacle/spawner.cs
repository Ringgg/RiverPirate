using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class spawner : MonoBehaviour {

	public List<GameObject> obstacles = new List<GameObject> ();

	private int X;

	void Start () {
		X = 0;
	}
	void Update () {
		if (Time.timeScale == 1f) {
			int los = Random.Range (1, 90);
			if (X >= 60) {
				if (los == 1) {
					GameObject obiekt = obstacles [Random.Range (0, obstacles.Count)];
					Instantiate (obiekt, this.transform.position, new Quaternion ());
					X = 0;
				}
			}
			X++;
		}

	}
}