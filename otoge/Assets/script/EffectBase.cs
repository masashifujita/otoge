using UnityEngine;
using System.Collections;

public class EffectBase : MonoBehaviour {
    public GameObject Effect1;
	public GameObject SE_tamb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject TapSE = Instantiate (SE_tamb);
            GameObject TapEffect = Instantiate(Effect1);
            TapEffect.transform.localPosition = transform.localPosition;
        }
	
	}
}
