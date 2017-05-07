using UnityEngine;
using System.Collections;

public class GlobalScore : MonoBehaviour {

  public static int score = 0;
    public static bool newScore;

	// Use this for initialization
	void Awake () {

    //GlobalScore.score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

  public static void addScore(int num) {


        Debug.Log("Old Score: " + GlobalScore.score);
    GlobalScore.score+=num;
        Debug.Log("New Score is: " + GlobalScore.score);
        GlobalScore.newScore = true;

  }

  public static int getScore() {

    return GlobalScore.score;

  }
}
