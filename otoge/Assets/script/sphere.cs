﻿using UnityEngine;
using System.Collections;

public class sphere : MonoBehaviour {
    public float amplitude = 0.01f; // 振幅
    private int frameCnt = 0; // フレームカウント
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        frameCnt += 1;
        if (10000 <= frameCnt)
        {
            frameCnt = 0;
        }
        if (0 == frameCnt % 2)
        {
            // 上下に振動させる（ふわふわを表現）
            float posYSin = Mathf.Sin(2.0f * Mathf.PI * (float)(frameCnt % 200) / (200.0f - 1.0f));
            iTween.MoveAdd(gameObject, new Vector3(0, amplitude * posYSin, 0), 0.0f);
        }

        //transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, 1), transform.position.z);
	}
}
