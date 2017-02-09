using UnityEngine;
using System.Collections;
using System.IO;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject[] notes;

    private float[] Timing;
    private int[] LineNum;
    private int NotesCount = 0;
    private AudioSource audioSource;
    private float startTime = 0;
    public float timeOffset = -1;

    public Text scoreText;
    private int score = 0;


    void LoatCSV()
    {
        int i = 0;
        TextAsset csv = Resources.Load("CSV/Normal_Easy") as TextAsset;
        StringReader reader = new StringReader(csv.text);
        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine();
            string[] values = line.Split(',');
            for(int j=0;j<values.Length;j++)
            {
                Timing[i] = float.Parse(values[0]);
                LineNum[i] = int.Parse(values[1]);

                //Timing[i] = Timing[i];
            }
            i++;
        }
    }

    // Use this for initialization
    void Start () {
        audioSource = GameObject.Find("GameMusic").GetComponent<AudioSource>();
        Timing = new float[1024];
        LineNum = new int[1024];
        LoatCSV();
        StartGame();
    }

    void Update ()
    {
        CheckNextNotes();
        scoreText.text = score.ToString();
    }

    public void StartGame()
    {
        startTime = Time.time;
        audioSource.Play();

    }

    void CheckNextNotes()
    {
        while(Timing[NotesCount] + timeOffset< GetMusicTime()
            && Timing[NotesCount] != 0)
        {
            SpawnNotes(LineNum[NotesCount]);
            NotesCount++;
        }
    }

    void SpawnNotes(int num)
    {
        GameObject go = Instantiate(notes[num-1]);
        //Instantiate(notes[num - 1], new Vector3(-7.0f+(1.0f * (num-1)), 10.0f, 0), Quaternion.identity);
    }

    float GetMusicTime()
    {
        float t= Time.time - startTime;
        return t;
    }

    public void GoodtimingFunc(int num)
    {
        Debug.Log("Line:" + num + "good");
        Debug.Log(GetMusicTime());
        Debug.Log("score:"+score);
        score++;
    }

}
