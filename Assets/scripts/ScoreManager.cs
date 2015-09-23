using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public static int score = 0;
	public static Text scoreText;

	void Start(){
		scoreText = GameObject.Find ("score").GetComponent<Text>();
		score = 0;
		SetScore (0);
	}

	public static void SetScore(int pointValue){
		score += pointValue;
		scoreText.text = "score: " + score;
	}
}

