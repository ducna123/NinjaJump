using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public GameObject lx;
    public GameObject ninja;
    public bool isput;
    private Rigidbody2D myBody;
	// Use this for initialization
	void Start () {
        myBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            isput = true;
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            isput = false;
            myBody.velocity = new Vector2(1, 5);
        }
        if (isput)
        {
            lx.transform.localScale = new Vector2(lx.transform.localScale.x, lx.transform.localScale.y - 0.0003f);
            ninja.transform.position = new Vector2(ninja.transform.position.x, ninja.transform.position.y - 0.003f);
        }
        if(isput == false)
        {
            lx.transform.localScale = new Vector2(lx.transform.localScale.x, lx.transform.localScale.y + 0.0003f);
            ninja.transform.position = new Vector2(ninja.transform.position.x, ninja.transform.position.y + 0.003f);
        }
	}
}
