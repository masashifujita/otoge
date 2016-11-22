using UnityEngine;
using System.Collections;

public class TapSE : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		AudioSource SE = GetComponent<AudioSource> ();
		if (!SE.isPlaying) {
			Destroy (gameObject);
		}
	}
}
