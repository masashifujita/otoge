using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

    public void SceneLoad()
    {
        Application.LoadLevel("scene/Game");
    }
    public void SceneCut()
    {
        Application.LoadLevel("scene/Result");
    }

    public void OnMouseEnter()
    {

    }
}
