using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private static int Scores;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        Scores = GameManager.score;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = Scores.ToString();
	}
}
