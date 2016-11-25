using UnityEngine;
using System.Collections;

public class Pointer : MonoBehaviour
{
    [SerializeField]
    ParticleSystem PointerEffect;
    [SerializeField]
    Camera Ecamera;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // マウスのワールド座標までパーティクルを移動し、パーティクルエフェクトを1つ生成する 
            Vector3 pos = Ecamera.ScreenToWorldPoint(Input.mousePosition + Ecamera.transform.forward * 10);
            PointerEffect.transform.position = pos;
            PointerEffect.Emit(1);
        }
    }
}
