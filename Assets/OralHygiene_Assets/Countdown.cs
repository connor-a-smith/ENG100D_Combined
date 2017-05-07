using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour {

	public Text countDownText ;
	private float startTime;
	private float timeOffset;
	public GameObject scoreScreen;
	public Text brushText;
	public Text flossText;
	private bool draggable = true;
	private bool clicked = false;
	public static Draggable dragging = null;

	// Use this for initialization
	void Start () {
		startTime = 120;
		flossText.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		//checks if the user is pressing on the draggable object
		RaycastHit2D hit = Physics2D.Raycast(
			Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector2.up);

		//if object is being pressed
		if (clicked || (hit && hit.collider.GetComponent<Countdown>() == this)) {
			if (!clicked) {
				timeOffset = Time.time;
			}
				
			clicked = true;


			float t = startTime - Time.time + timeOffset;

			if ( (t % 60) == 0) {
				t -= 1;
			}
			if (t < 0 ) {
				//loadFlossText();
				loadScoreScreen();
			}

			string minutes = ((int) t / 60).ToString();
			string seconds = (t % 60).ToString("00");

			if (seconds == "60") {
				seconds = "59";
			}

			if (t >= 0) {
				countDownText.text = minutes + ":" + seconds;
			}

		}
	}

	public void loadScoreScreen() {
		scoreScreen.SetActive (true);
		scoreScreen.GetComponentsInChildren<TeethScore> ()[0].setElapsedTime (10);
	}

	public void loadFlossText() {
		brushText.enabled = false;
		flossText.enabled = true;
	}

	public static string PrependWithNum(float f, int numToInsert, int nTimes) {
		string str = f.ToString();
		for (int i = 0; i < nTimes - 1; i++) {
			str = str.Insert(0, numToInsert.ToString("f2"));
		}
		return str;
	}


}
