using UnityEngine;
using System.Collections;

public class tilt : MonoBehaviour {
	void FixedUpdate () {
		gameObject.transform.Rotate((Mathf.Sin(5 * Time.time))/3,0,0);
	}
}
