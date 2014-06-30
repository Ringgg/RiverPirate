using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {
    static Object instance;
	// Use this for initialization
	void Start () {
        GameObject.DontDestroyOnLoad(this.gameObject);
        if (instance != null)
            Destroy(this.gameObject);
        else
            instance = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
