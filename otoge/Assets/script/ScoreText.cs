using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoretext;
    public int miss, good;

	// Use this for initialization
	void Start () {
        scoretext.text = "Score : ";
        miss = 0; good = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
