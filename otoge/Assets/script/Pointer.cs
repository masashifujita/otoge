using UnityEngine;
using System.Collections;

public class Pointer : MonoBehaviour
{
    [SerializeField]
    GameObject Click_Effect;
    [SerializeField]
    GameObject Drag_Effect;

    private GameObject m_ClickEffect;
    private GameObject m_DragEffect;
    private ParticleSystem m_ClickParticle;
    private ParticleSystem m_DragParticle;

    // Use this for initialization
    void Start()
    {
        m_ClickEffect = (GameObject)Instantiate(Click_Effect);
        m_DragEffect = (GameObject)Instantiate(Drag_Effect);

        m_ClickParticle = m_ClickEffect.GetComponent<ParticleSystem>();
        m_DragParticle = m_DragEffect.GetComponent<ParticleSystem>();
        m_ClickParticle.Stop();
        m_DragParticle.Stop();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 20f;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        m_DragEffect.transform.position = mousePosition;

        if (Input.GetMouseButtonDown(0))
        {
            m_ClickEffect.transform.position = mousePosition;
            m_ClickParticle.Play();
            m_DragParticle.Play();
        }
        if (Input.GetMouseButtonUp(0))
        {
            m_ClickParticle.Stop();
            m_DragParticle.Stop();
        }
    }
}
