using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	public float x;
	public bool drawBox;
	public GameObject player;
	float y;
	int screenWidth, screenHeight;

	void Start () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;
		x = 0f;
		y = 0f;
		Time.timeScale = 0.0f;
		drawBox = true;
	}
	
	void OnGUI () {
		GUI.skin.button.fontSize = screenHeight / 25;
		GUI.skin.box.fontSize = screenHeight / 30;
		GUI.skin.label.fontSize = screenHeight / 30;
		//score display
		GUI.Box(new Rect(0, 0, screenWidth/2, screenHeight/10), "SCORE");
		GUI.Label(new Rect(screenWidth/6, screenHeight/20, 200, 200), y.ToString());
		//health display
		GUI.Box(new Rect(screenWidth/2, 0, screenWidth/2, screenHeight/10), "LIFE");
		GUI.Label (new Rect (screenWidth/5 + screenWidth/2, screenHeight/20, 200, 200), player.GetComponent<Player_Controller> ().life.ToString ());
		//start button

		if(drawBox)
		{
			if(GUI.Button (new Rect( (screenWidth/2 - screenWidth/8), (screenHeight/2 - screenHeight/20) ,screenWidth/4, screenHeight/10), "PLAY"))
			{
				Time.timeScale = 0.1f;
                StartCoroutine(waitForDice());
				drawBox = false;
			}
		}
	}

	void Update() {
		//score update
		x += Time.deltaTime * 10;
		y = Mathf.Round(x);
	}

    IEnumerator waitForDice()
    {
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 1.0f;
    }
}