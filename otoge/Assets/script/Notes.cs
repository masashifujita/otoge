using System;
using UnityEngine;

public class Notes : MonoBehaviour {

    public int lineNum;
    private GameManager gameManager;

	// Use this for initialization
	void Start ()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.down * 10 * Time.deltaTime;
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }        
    }

    void OnTriggerStay(Collider collider)
    {
        //switch (lineNum)
        //{
        //    case 0:
        //        if (Input.GetKeyDown(KeyCode.L))
        //        {
        //            Destroy(gameObject);
        //        }
        //        break;
        //    case 1:
        //        if (Input.GetKeyDown(KeyCode.K))
        //        {
        //            Destroy(gameObject);
        //        }
        //        break;
        //    case 2:
        //        if (Input.GetKeyDown(KeyCode.J))
        //        {
        //            Destroy(gameObject);
        //        }
        //        break;
        //    case 3:
        //        if (Input.GetKeyDown(KeyCode.H))
        //        {
        //            Destroy(gameObject);
        //        }
        //        break;
        //    case 4:
        //        if (Input.GetKeyDown(KeyCode.F))
        //        {
        //            Destroy(gameObject);
        //        }
        //        break;
        //    case 5:
        //        if (Input.GetKeyDown(KeyCode.D))
        //        {
        //            Destroy(gameObject);
        //        }
        //        break;
        //    case 6:
        //        if (Input.GetKeyDown(KeyCode.S))
        //        {
        //            Destroy(gameObject);
        //        }
        //        break;
        //    case 7:
        //        if (Input.GetKeyDown(KeyCode.A))
        //        {
        //            Destroy(gameObject);
        //        }
        //        break;
        //    default:
        //        Destroy(gameObject);
        //        break;
        //}

        switch (lineNum)
        {
            case 0:
                CheckInput(KeyCode.L);
                break;
            case 1:
                CheckInput(KeyCode.K);
                break;
            case 2:
                CheckInput(KeyCode.J);
                break;
            case 3:
                CheckInput(KeyCode.H);
                break;
            case 4:
                CheckInput(KeyCode.F);
                break;
            case 5:
                CheckInput(KeyCode.D);
                break;
            case 6:
                CheckInput(KeyCode.S);
                break;
            case 7:
                CheckInput(KeyCode.A);
                break;
            default:
                Destroy(gameObject);
                break;
        }
    }

    void CheckInput(KeyCode key)
    {
        if(Input.GetKeyDown(key))
        {
            gameManager.GoodtimingFunc(lineNum);
            Destroy(gameObject);
        }
    }
}
