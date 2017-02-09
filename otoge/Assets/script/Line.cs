using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {

    private GameObject[] notes;
    public GameObject Effect1;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GameObject TapEffect = Instantiate(Effect1);
            Vector3 pos = TapEffect.transform.localPosition;
            pos.x = -7.0f;
            TapEffect.transform.localPosition = pos;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject TapEffect = Instantiate(Effect1);
            Vector3 pos = TapEffect.transform.localPosition;
            pos.x = -5.0f;
            TapEffect.transform.localPosition = pos;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject TapEffect = Instantiate(Effect1);
            Vector3 pos = TapEffect.transform.localPosition;
            pos.x = -3.0f;
            TapEffect.transform.localPosition = pos;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject TapEffect = Instantiate(Effect1);
            Vector3 pos = TapEffect.transform.localPosition;
            pos.x = -1.0f;
            TapEffect.transform.localPosition = pos;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            GameObject TapEffect = Instantiate(Effect1);
            Vector3 pos = TapEffect.transform.localPosition;
            pos.x = 1.0f;
            TapEffect.transform.localPosition = pos;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            GameObject TapEffect = Instantiate(Effect1);
            Vector3 pos = TapEffect.transform.localPosition;
            pos.x = 3.0f;
            TapEffect.transform.localPosition = pos;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject TapEffect = Instantiate(Effect1);
            Vector3 pos = TapEffect.transform.localPosition;
            pos.x = 5.0f;
            TapEffect.transform.localPosition = pos;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GameObject TapEffect = Instantiate(Effect1);
            Vector3 pos = TapEffect.transform.localPosition;
            pos.x = 7.0f;
            TapEffect.transform.localPosition = pos;
        }

    }
}
