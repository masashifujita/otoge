using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Maouse : MonoBehaviour {

    public Renderer rend;
    GameObject text;
    void Start()
    {
        text = GameObject.Find("Canvas/FreePlay");
        //rend = GetComponent<Renderer>();
    }
    void OnMouseEnter()
    {
        
        //rend.material.color = Color.red;
    }
    void OnMouseOver()
    {
        //rend.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
    }
    void OnMouseExit()
    {
        
        //rend.material.color = Color.white;
    }
}
