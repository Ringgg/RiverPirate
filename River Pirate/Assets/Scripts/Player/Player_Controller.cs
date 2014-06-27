using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player_Controller : MonoBehaviour {

	public int life {get; private set; }
	public float speed;
	public float position;
	public int shorecrash;
	public List<Mesh> meshes = new List<Mesh> ();
	private float mysz;
	private int res;
	private GameObject betterPlace;
    private Mesh currentMesh = null;
    private MeshFilter meshFilter;
    private MeshCollider meshCollider;

	void Start () {
		betterPlace = GameObject.Find ("Moving");
		res = Screen.width;
		life = meshes.Count;
		position = 0;
		shorecrash = 30;

        if (meshes.Count > 0)
        {
            currentMesh = meshes[0];
        }
        else
        {
            currentMesh = GameObject.CreatePrimitive(PrimitiveType.Cube).GetComponent<MeshFilter>().mesh;
        }

        meshFilter = gameObject.GetComponent<MeshFilter>();
        meshCollider = gameObject.GetComponent<MeshCollider>();
	}

	void FixedUpdate () {
		PositionChanging ();
		shorecrash++;
	}

    /// <summary>
    /// Player gets damage of a value. 
    /// This function handles model destruction and restart in case of death.
    /// </summary>
    /// <param name="value">How many life points looses the player.</param>
    public void GetDamage(int value)
    {
        life -= value;

        if (life <= 0)
        {
            //Debug.Log ("restart");
            Application.LoadLevel(Application.loadedLevel);
        }
        else
        {
            if (life > meshes.Count)
            {
                currentMesh = meshes[meshes.Count - 1];
            }

            currentMesh = meshes[meshes.Count - life];
            this.meshFilter.mesh = currentMesh;
            this.meshCollider.sharedMesh = currentMesh;
        }

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


