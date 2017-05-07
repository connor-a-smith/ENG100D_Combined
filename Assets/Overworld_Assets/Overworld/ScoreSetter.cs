using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Setting Text Score in Overworld to: " + GlobalScore.score);
		GetComponent<Text> ().text = "Score: " + GlobalScore.score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	    if (GlobalScore.newScore)
        {
            Debug.Log("Setting Text Score in Overworld to: " + GlobalScore.score);
            GetComponent<Text>().text = "Score: " + GlobalScore.score.ToString();
            GlobalScore.newScore = false;
        }
	}
}
