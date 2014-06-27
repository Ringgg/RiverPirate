using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	private GameObject gui;
	private float Speed;
	private bool ZderzylSie;
	private Player_Controller kontroller;
	void Start () {
		ZderzylSie = false;
		gui = GameObject.Find ("GUI");
		Speed = gui.GetComponent<settings>().speed;
		rigidbody.AddForce (Vector3.left, ForceMode.Impulse);
	}
	void OnCollisionEnter (Collision col)
	{
		if (!ZderzylSie)
		{
			kontroller = col.gameObject.GetComponent<Player_Controller>();
            if (kontroller != null)
            {
                kontroller.GetDamage(1);
                
                this.collider.enabled = false;
            }

            //Debug.Log("zderzenie");
            
		}
		
		ZderzylSie = true;
	}
	void FixedUpdate () {

		//rigidbody.AddForce (Vector3.left * Speed, ForceMode.Acceleration);
		//if (transform.position.x < -50)
		Destroy (gameObject, 10f);
	}
}
