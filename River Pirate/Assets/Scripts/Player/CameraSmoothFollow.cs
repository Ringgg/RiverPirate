using UnityEngine;
using System.Collections;

public class CameraSmoothFollow : MonoBehaviour {

    public Transform target;
    private Vector3 targetOffset = new Vector3();

	// Use this for initialization
	void Start () {
        targetOffset = target.position - this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = Vector3.Lerp(this.transform.position, target.position - targetOffset, 0.1f);
	}
}
